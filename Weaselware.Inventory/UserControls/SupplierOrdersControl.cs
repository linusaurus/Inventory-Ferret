using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DataLayer.Services;
using DataLayer.Entities;
using System.Net.Mail;
using System.Threading;
using System.Web.UI;
using System.IO;
using Neodynamic.SDK.Printing;

namespace Weaselware.InventoryFerret {
    public partial class SupplierOrdersControl : System.Windows.Forms.UserControl {

        BadgerDataModel _context;
        private Supplier selectedSupplier;
        private PurchaseOrder selectedOrder;
        private List<PurchaseOrder> supplierOrders;
        private List<Supplier> suppliers;
        SuppliersService supService;
        OrdersService ordersService;
        JobsService jobService;
        LineItemsService lineItemService;
        LabelService labelService;
        BindingSource bsLineItems = new BindingSource();
        PartsService partsService;

        public SupplierOrdersControl() {
            InitializeComponent();
            this.dgOrderItems.AutoGenerateColumns = false;

        }

        public SupplierOrdersControl(BadgerDataModel ctx) {
            InitializeComponent();
            this.dgOrderItems.AutoGenerateColumns = false;
            _context = ctx;
            supService = new SuppliersService(ctx);
            labelService = new LabelService();
            jobService = new JobsService(ctx);
            txtSearchSuppliers.TextChanged += (txtJobSearch_TextChanged);
            this.lbSuppliers.SelectedIndexChanged += lbSuppliers_SelectedIndexChanged;
            lvSuppliersOrders.SelectedIndexChanged += lvSuppliersOrders_SelectedIndexChanged;
            ordersService = new OrdersService(ctx);
            lineItemService = new LineItemsService(ctx);
            txtSearchSuppliers.Text =
               (Properties.Settings.Default.LastSupplierSearch != string.Empty) ? Properties.Settings.Default.LastSupplierSearch : string.Empty;

            suppliers = supService.SuppliersWithOpenOrders();
            this.lbSuppliers.DisplayMember = "SupplierName";
            this.lbSuppliers.DataSource = suppliers;
            partsService = new PartsService(ctx);
        }
        /// <summary>
        /// Search for Suppliers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtJobSearch_TextChanged(object sender, EventArgs e) {
            TextBox tb = (TextBox)sender;
            string searchTxt = tb.Text;
            suppliers = supService.Find(searchTxt);
            //suppliers = supService.SuppliersWithOpenOrders();
            this.lbSuppliers.DisplayMember = "SupplierName";
            this.lbSuppliers.DataSource = suppliers;
            Properties.Settings.Default.LastSupplierSearch = searchTxt;
            Properties.Settings.Default.Save();
        }


        // Populate the Supplier Order List ---
        private void lbSuppliers_SelectedIndexChanged(object sender, EventArgs e) {
            List<PurchaseOrder> ordersList = new List<PurchaseOrder>();
            ListBox lb = (ListBox)sender;
            selectedSupplier = (Supplier)lb.SelectedItem;
            int key = selectedSupplier.SupplierId;
            if (selectedSupplier != null)
                LoadSupplierOrders(selectedSupplier);

        }

        private void lvSuppliersOrders_SelectedIndexChanged(object sender, EventArgs e) {
            ListView lv = (ListView)sender;
            if (lv.SelectedItems.Count > 0)
            {

                string temp = lv.SelectedItems[0].Text;
                //Text = "Inventory Manager : " + temp;
                int orderNum;
                if (int.TryParse(temp, out orderNum))
                {
                    selectedOrder = ordersService.GetOrderByID(orderNum);
                    bsLineItems.DataSource = lineItemService.GetOrderItems(orderNum);
                    dgOrderItems.DataSource = bsLineItems;
                    //this.dgOrderItems.DataSource = lineItemService.GetOrderItems(orderNum);
                }

            }

        }

        private void SupplierOrdersControl_Load(object sender, EventArgs e) {

            dgOrderItems.DataSource = bsLineItems;

        }

        private void dgOrderItems_SelectionChanged(object sender, EventArgs e) {
            DataGridView dg = (DataGridView)sender;
            if (dgOrderItems.DataSource != null)
            {
                if (dgOrderItems.RowCount > 0)
                {
                   
                    txtItemNotes.DataBindings.Clear();
                    PurchaseLineItem lineItem = (PurchaseLineItem)dg.CurrentRow.DataBoundItem;

                    if (lineItem != null)
                    {
                        txtItemNotes.DataBindings.Add("Text", lineItem, "Note");
                        label4.Text = String.Format("Order Number : {0}", lineItem.PurchaseOrderId.Value);
                        if (lineItem.PurchaseOrder.JobId.HasValue) { txtJobName.Text = lineItem.PurchaseOrder.Job?.Jobname ?? "Error"; }
                        else { txtJobName.Text = "***Job Assignment Error***"; }
                        txtPurchaser.Text = lineItem.PurchaseOrder.Employee.Firstname + " " +
                            lineItem.PurchaseOrder.Employee.Lastname;
                        txtOrderDate.Text = lineItem.PurchaseOrder.OrderDate.Value.ToShortDateString();
                    }
                }

            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e) {
            _context.SaveChanges();
        }

        private void chbShowRecieved_CheckedChanged(object sender, EventArgs e) {
            CheckBox cb = (CheckBox)sender;
            LoadSupplierOrders(selectedSupplier);
        }

        private void LoadSupplierOrders(Supplier supplier) {

            int key = selectedSupplier.SupplierId;
            if (selectedSupplier != null)
            {

                supplierOrders = ordersService.GetSupplierOrders(key).Where(c => c.Recieved == chbShowRecieved.Checked).ToList();

                if (supplierOrders.Count < 1) { dgOrderItems.DataSource = null; label4.Text = string.Empty; }
                lvSuppliersOrders.Items.Clear();
                foreach (PurchaseOrder p in supplierOrders)
                {

                    ListViewItem lvi = new ListViewItem(p.OrderNum.ToString().Trim());
                    lvi.SubItems.Add(((DateTime)p.OrderDate).Date.ToShortDateString());
                    if (p.Recieved == true)
                    {
                        lvi.SubItems.Add("Y");
                        lvi.BackColor = System.Drawing.Color.AliceBlue;
                    }

                    else
                    {
                        lvi.SubItems.Add("--");
                        lvi.BackColor = System.Drawing.Color.PaleGoldenrod;
                    }

                    lvSuppliersOrders.Items.Add(lvi);
                }
            }



        }

        private void btnRecieveOrderItems_Click(object sender, EventArgs e) {

            OrderReciept receipt = null;

            if (selectedOrder != null)
            { receipt = ordersService.RecievedOrder(selectedOrder, Globals.CurrentLoggedUserID); }

            if (receipt.OrderReceiptId != default(int))
            {
                string notifyTO = selectedOrder.Employee.EmployeeEmail.ToString();
                var frm = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Main").FirstOrDefault();
                TabPage orderTab = new TabPage();
                OrderReceiptControl control = new OrderReceiptControl(receipt, _context);
                
                orderTab.Controls.Add(control);

                orderTab.Text = "Receive : " + receipt.OrderReceiptId.ToString();
                ((Main)frm).MainTabControl.TabPages.Add(orderTab);
                ((Main)frm).MainTabControl.SelectedTab = orderTab;
               
             ////   new Thread(() => NotificationService.SendNotificaion(notifyTO, selectedOrder)).Start();
            }

        }

        private void btnPrintSelectedItemsLabels_Click(object sender, EventArgs e)
        {
            DataGridView dg = dgOrderItems;
            if (dgOrderItems.DataSource != null)
            {
                if (dgOrderItems.RowCount > 0)
                {

                    
                    PurchaseLineItem lineItem = (PurchaseLineItem)dg.CurrentRow.DataBoundItem;

                    if (lineItem != null)
                    {
                        int id = lineItem.JobId.Value;
                        Job job = jobService.Find(id);
                        string JobName = job.Jobname;
                        string revdate = lineItem.PurchaseOrder.RecievedDate?.ToShortDateString() ?? "---NA---";
                        string orderNum = lineItem.PurchaseOrderId?.ToString() ?? "---NA---";
                        string receiver = lineItem.PurchaseOrder.Employee?.Lastname ?? "---NA---";
                        
                       ThermalLabel label = labelService.GenerateInventoryDetailLabel(lineItem.LineId.ToString(), JobName, orderNum, receiver, revdate);
                       labelService.PrintLabel(label,int.Parse(this.numericUpDownCopies.Value.ToString()));
                    }
                }

            }
        }

        private void dgOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OnOpenOrdersCliecked(object sender, EventArgs e)
        {
            suppliers = supService.SuppliersWithOpenOrders();
            this.lbSuppliers.DisplayMember = "SupplierName";
            this.lbSuppliers.DataSource = suppliers;
        }

        private void dgOrderItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dg =(DataGridView) sender;
            if (dg.DataSource != null)
            {
                if (dg.RowCount > 0)
                {
                    PurchaseLineItem lineItem = (PurchaseLineItem)dg.CurrentRow.DataBoundItem;

                    if (e.ColumnIndex == 1)
                    {
                        if(lineItem.PartId > 0)
                        {
                            PartForm partForm = new PartForm();
                            if (lineItem != null)
                            {
                                var part = partsService.Find(lineItem.PartId.Value);
                                PartView partView = new PartView(part, _context);

                                partForm.Controls.Add(partView);
                                partView.Dock = DockStyle.Fill;
                                partForm.Show();
                            }
                        }

                    }
                }
               

            }
          
        }
    }

   
    
}
