using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Services;
using DataLayer.Interfaces;
using DataLayer.Entities;
using System.Windows.Forms;
using Neodynamic.SDK.Printing;

namespace Weaselware.InventoryFerret {
    public partial class OrderReceiptsControl : UserControl {


        BadgerDataModel context;
        // ---Services-------------------
        OrderRecieptService ordersService;
        IEmployeeService empService;
        ISuppliersService suppliersService;
        IJobsService jobsService;
        IInventoryService inventoryService;
        IClaimService claimsService;
        LabelService labelService;
        //----Active Selections---------
        Supplier selectedSupplier;
        Job selectedJob;
        string searchMode;
        //------------------------------
        List<OrderReciept> jobReciepts;
        List<OrderReciept> supplierReciepts;
        IOrdersService poService;

        BindingSource bsRecieptItemBindingSource;

        public OrderReceiptsControl(BadgerDataModel Context) {

            InitializeComponent();
            dgRecieptItems.AutoGenerateColumns = false;

            context = Context;
            ordersService = new OrderRecieptService(context);
            suppliersService = new SuppliersService(context);
            jobsService = new JobsService(context);
            inventoryService = new InventoryService(context);
            poService = new OrdersService(context);
            empService = new EmployeeService(context);
        }

        private void OrderReceiptsControl_Load(object sender, EventArgs e) {

            bsRecieptItemBindingSource = new BindingSource();
            labelService = new LabelService();
        }

        private void tbJobSearch_TextChanged(object sender, EventArgs e) {

            TextBox tb = (TextBox)sender;
            string searchTxt = tb.Text;
            lbJobListing.DisplayMember = "Jobname";
            if (tb.TextLength > 0)
            {
                this.lbJobListing.DataSource = jobsService.GetJobs(searchTxt);
            }
            

        }
        /// <summary>
        /// Select Job and retrieve order in listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbJobListing_SelectedIndexChanged(object sender, EventArgs e) {

            ListBox lb = (ListBox)sender;
            selectedJob = (Job)lb.SelectedItem;
            if (lb.DataSource != null)
            {
                if (lb.SelectedItems.Count > 0)
                {
                    LoadJobReciepts(selectedJob);
                }
                else
                {

                }   
            }
        }

        private void lbOrderRecieptList_SelectedIndexChanged(object sender, EventArgs e) {

            ListBox lb = (ListBox)sender;
            OrderReciept jReciept = (OrderReciept)lb.SelectedItem;
            if (lb.DataSource != null)
            {
                if (lb.SelectedItems.Count > 0)
                {dgRecieptItems.DataSource = inventoryService.GetOrderRecieptItems(jReciept.OrderReceiptId);}
                BindRecieptDetails(jReciept);
            }

        }

        private void BindRecieptDetails(OrderReciept reciept) {

            var order = poService.GetOrderByID(reciept.OrderNum.Value);
            if(order.Job != null)this.txtJobName.Text = order.Job.Jobname.ToString() ;
            this.txtOrderDate.Text = order.OrderDate.Value.ToShortDateString();
            this.txtPoNumber.Text = order.OrderNum.ToString();
            this.txtPurchaser.Text = order.Employee.Firstname.ToString() + " " + order.Employee.Lastname.ToString();
            this.txtRecievedDate.Text = reciept.ReceiptDate.Value.ToShortDateString();
            this.txtSupplier.Text = order.Supplier.SupplierName;
            this.txtReciever.Text = empService.Find(reciept.EmployeeId.Value).Lastname.ToString();
        }

        private void tbSearchSuppliers_TextChanged(object sender, EventArgs e) {

            TextBox tb = (TextBox)sender;
            string searchSups = tb.Text;
            if (tb.TextLength > 0)
            {
                lbSupplierList.DisplayMember = "SupplierName";
                lbSupplierList.DataSource = suppliersService.Find(tb.Text);
            }
        }

        private void lbSupplierList_SelectedIndexChanged(object sender, EventArgs e) {

            ListBox lb = (ListBox)sender;
            selectedSupplier = (Supplier)lb.SelectedItem;
            if (lb.DataSource != null)
            {
                if (lb.SelectedItems.Count != 0)
                {
                    LoadSupplierReciepts(selectedSupplier);
                }
            }

        }

        private void LoadJobReciepts(Job job) {

            int key = job.JobId;
            if (job != null)
            {
                jobReciepts = ordersService.GetJobReciepts(key);
                // if (jobReciepts.Count < 1) { dgOrderItems.DataSource = null; label4.Text = string.Empty; }
                lvJobReciepts.Items.Clear();
                foreach (OrderReciept oreciept in jobReciepts)
                {

                    ListViewItem lvi = new ListViewItem(oreciept.OrderReceiptId.ToString());
                    lvi.Tag = oreciept;
                    lvi.SubItems.Add(((DateTime)oreciept.ReceiptDate).Date.ToShortDateString());
                    lvJobReciepts.Items.Add(lvi);
                }
            }
        }

        private void LoadSupplierReciepts(Supplier supplier) {

            int key = supplier.SupplierId;
            if (supplier != null)
            {

                supplierReciepts = ordersService.GetSupplierReciepts(key).OrderByDescending(c=> c.ReceiptDate).ToList();
                dgRecieptItems.DataSource = null;
                // if (jobReciepts.Count < 1) { dgOrderItems.DataSource = null; label4.Text = string.Empty; }
                lvSuppliersReciept.Items.Clear();
                foreach (OrderReciept oreciept in supplierReciepts)
                {

                    ListViewItem lvi = new ListViewItem(oreciept.OrderReceiptId.ToString());
                    lvi.Tag = oreciept;
                    if (oreciept.ReceiptDate != null)
                    { lvi.SubItems.Add(((DateTime)oreciept.ReceiptDate).Date.ToShortDateString()); }

                    lvSuppliersReciept.Items.Add(lvi);
                }
            }
        }

        private void lvSuppliersReciept_SelectedIndexChanged(object sender, EventArgs e) {

            ListView lv = (ListView)sender;
            if (lv.Items.Count > 0)
            {
                if (lv.SelectedItems.Count > 0)
                {
                    OrderReciept reciept =(OrderReciept) lv.SelectedItems[0].Tag;
                    bsRecieptItemBindingSource.DataSource = reciept.Inventory.ToList();
                    dgRecieptItems.DataSource = bsRecieptItemBindingSource;
                    BindRecieptDetails(reciept);
                }
            }

        }

        private void txtRecievedSupliertemSearch_TextChanged(object sender, EventArgs e) {

            TextBox tb = (TextBox)sender;
            string search = tb.Text;
            if (tb.Text.Length > 0)
            {
                if (selectedSupplier != null && searchMode == "S")
                {
                    dgRecieptItems.DataSource = inventoryService.GetSupplierInventory(selectedSupplier, search);
                }
                else if(selectedJob != null && searchMode =="J")
                {
                    dgRecieptItems.DataSource = inventoryService.GetJobInventory(selectedJob);
                }
            }
        }

        private void dgRecieptItems_SelectionChanged(object sender, EventArgs e) {

            if (dgRecieptItems.DataSource != null)
            {
                if (dgRecieptItems.SelectedRows.Count > 0)
                {
                    if (dgRecieptItems.SelectedRows[0].DataBoundItem != null)
                    {                    
                        Inventory i = (Inventory)bsRecieptItemBindingSource.Current;                        
                    }
 
      
                }
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e) {

           
        }

        private void txtRecievedSupliertemSearch_TabIndexChanged(object sender, EventArgs e) {

        }
        /// <summary>
        /// Select a Job OrderReciept to show the items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvJobReciepts_SelectedIndexChanged(object sender, EventArgs e) {

            ListView lb = (ListView)sender;
            if (lb.Items.Count > 0)
            {
                if (lb.SelectedItems.Count > 0)
                {
                    OrderReciept reciept = (OrderReciept)lb.SelectedItems[0].Tag;
                    bsRecieptItemBindingSource.DataSource = reciept.Inventory.ToList();
                    dgRecieptItems.DataSource = bsRecieptItemBindingSource;
                    BindRecieptDetails(reciept);

                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {

            TabControl tb = (TabControl)sender;
            if (tb.SelectedTab.Text == "Jobs")
            {
                this.labelSearch.Text = "Jobs Recieved Items Search";
                searchMode = "J";
            }
            else if (tb.SelectedTab.Text == "Suppliers")
            {
                this.labelSearch.Text = "Supplier Recieved Items Search";
                searchMode = "S";
            }

        }

        private void PrintSelectedItems()
        {
            labelService = new LabelService();
            string jobName = txtJobName.Text;
            int qnty = int.Parse(txtLabelQnty.Text);
            if (dgRecieptItems.DataSource != null)
            {
                if (dgRecieptItems.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgRecieptItems.SelectedRows)
                    {
                      
                       Inventory inv = (Inventory)bsRecieptItemBindingSource[row.Index];
                       ThermalLabel lb = labelService.GenerateInventoryLabel(inv.LineId.ToString(),
                                                   jobName,
                        DateTime.Today.ToShortDateString());
                       labelService.PrintLabel(lb,qnty);
                    }


                }
            }


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           string jobname = txtJobName.Text;
            if (jobname.Length > 0)
            {
                PrintSelectedItems();
            }

        }

        private void ctxLineItems_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {

                case "Print Selected Label":
                    string jobname = txtJobName.Text;
                    if (jobname.Length > 0)
                    {
                        PrintSelectedItems();
                    }

                    break;
                case "Open Purchase Order":
                    if (dgRecieptItems.DataSource != null)
                    {
                        if (dgRecieptItems.SelectedRows.Count > 0)
                        {
                            Inventory selectedInventory = (Inventory)bsRecieptItemBindingSource[dgRecieptItems.CurrentRow.Index];
                            PurchaseOrder po = poService.GetOrderByID(selectedInventory.OrderReceipt.OrderNum.Value);
                            TabPage tab = new TabPage();
                            tab.Text = "Order" + " : " + po.OrderNum.ToString();
                            PurchaseOrderControl poctr = new PurchaseOrderControl(po);
                            poctr.Dock = DockStyle.Fill;
                            tab.Controls.Add(poctr);
                            var frm = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Main").FirstOrDefault();
                            ((Main)frm).MainTabControl.TabPages.Add(tab);
                            ((Main)frm).MainTabControl.SelectedTab = tab;

                        }
                    }
                    break;
                case "New Part From item":
                    if (dgRecieptItems.DataSource != null)
                    {
                        if (dgRecieptItems.SelectedRows.Count > 0)
                        {
                            Inventory selectedInventory = (Inventory)bsRecieptItemBindingSource[dgRecieptItems.CurrentRow.Index];
                            PurchaseOrder po = poService.GetOrderByID(selectedInventory.OrderReceipt.OrderNum.Value);
                            Supplier sup = suppliersService.Find(po.SupplierId.Value);
                            Part part = new Part();
                            part.SupplierId = sup.SupplierId;
                            part.ItemDescription = selectedInventory.Description;
                            part.Cost = 0.0m;
                            part.UseSupplierNameFlag = false;
                            part.DateAdded = DateTime.Today;
                            IEmployeeService emps = new EmployeeService(context);
                            part.AddedBy = emps.Find(Globals.CurrentLoggedUserID).Firstname.ToString();
                            part.Uid = selectedInventory.UnitOfMeasure;
                            context.Part.Add(part);


                            //context.SaveChanges();
                        }
                    }

                    break;
                default:
                    break;
            }
        }

        private void dgRecieptItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRecieptItems.DataSource != null)
            {
                if (dgRecieptItems.SelectedRows.Count > 0)
                {
                    Inventory selectedInventory = (Inventory)bsRecieptItemBindingSource[e.RowIndex];
                    PurchaseOrder po = poService.GetOrderByID(selectedInventory.OrderReceipt.OrderNum.Value);
                    TabPage tab = new TabPage();
                    tab.Text = "Order" + " : " + po.OrderNum.ToString();
                    PurchaseOrderControl poctr = new PurchaseOrderControl(po);
                    poctr.Dock = DockStyle.Fill;
                    tab.Controls.Add(poctr);
                    var frm = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Main").FirstOrDefault();
                    ((Main)frm).MainTabControl.TabPages.Add(tab);
                    ((Main)frm).MainTabControl.SelectedTab = tab;
                    
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtRecievedDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveEdits_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }
    }
}
