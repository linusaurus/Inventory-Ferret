/* ------------------------------
Order Reciept View Control
programmer r.young
date: 3-31-2016
--------------------------------*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Neodynamic.SDK.Printing;
using System.Windows.Forms;
using DataLayer.Entities;
using DataLayer.Services;

namespace Weaselware.InventoryFerret
{
    public partial class OrderReceiptControl : UserControl {

        private OrderReciept _receipt;
        private List<Inventory> inventoryItems;
        private Inventory selectedInventoryItem;
        BindingSource bsOrderReceiptItems = new BindingSource();
        BadgerDataModel _context;
        JobsService jService;
        OrdersService oService;
        #region Constructors




        public OrderReceiptControl() {
            InitializeComponent();
        }

        public OrderReceiptControl(BadgerDataModel ctx) {
            InitializeComponent();
            this._context = ctx;
        }


        public OrderReceiptControl(OrderReciept receipt, BadgerDataModel ctx) {
            InitializeComponent();
            this._context = ctx;
            _receipt = receipt;
            jService = new JobsService(ctx);
            oService = new OrdersService(ctx);
        }

        #endregion

        public void SetDataSource(OrderReciept orderReceipt) {
            _receipt = orderReceipt;
        }


        private void OrderReceiptControl_Load(object sender, EventArgs e) {
            this.dgOrderReceiptItems.AutoGenerateColumns = false;
            this.dgOrderReceiptItems.SelectionChanged += dgOrderReceiptItems_SelectionChanged;
            BindOrderReceiptItems(_receipt);
        }

        void dgOrderReceiptItems_SelectionChanged(object sender, EventArgs e) {
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {
                if (dg.RowCount > 0)
                {
                    selectedInventoryItem = (Inventory)dg.CurrentRow.DataBoundItem;
                    if (selectedInventoryItem !=   null)
                    {
                        txtNotes.DataBindings.Clear();
                        txtNotes.DataBindings.Add("Text", selectedInventoryItem, "Note");
                    }
                  
                }

            };
        }
        /// <summary>
        /// Bind the Control and Grid to reciept Object
        /// </summary>
        /// <param name="reciept"></param>
        private void BindOrderReceiptItems(OrderReciept reciept) {
            inventoryItems = (from c in _context.Inventory where c.OrderReceiptID == reciept.OrderReceiptId select c).ToList();
            Employee employee = (from c in _context.Employee where c.EmployeeId == reciept.EmployeeId select c).FirstOrDefault();
            this.txtOrderReceiptID.Text = reciept.OrderReceiptId.ToString();
            this.txtOrderNo.Text = reciept.OrderNum.ToString();
            this.txtReciptDate.Text = reciept.ReceiptDate.Value.ToShortDateString();
            this.txtReceivedBy.Text = employee.Firstname.ToString() + " " + employee.Lastname.ToString();
            // Bind to Binding source and set source
            this.dgOrderReceiptItems.DataSource = bsOrderReceiptItems;
            bsOrderReceiptItems.DataSource = inventoryItems;
        }

        private void CloseBox_Click(object sender, EventArgs e) {
            TabPage tabpage = (TabPage)this.Parent;
            TabControl tabControl = (TabControl)tabpage.Parent;
            tabControl.TabPages.Remove(tabpage);
        }

        private void btnSaveChanges_Click(object sender, EventArgs e) {
            _context.SaveChanges();
        }
        /// <summary>
        /// Print Barcodes of Selected LineItems
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e) {

            LabelService lbService = new LabelService();
            string jobName = oService.GetOrderByID(_receipt.OrderNum.Value).Job.Jobname;
            if (dgOrderReceiptItems.DataSource != null)
            {
                if (dgOrderReceiptItems.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow  row in dgOrderReceiptItems.SelectedRows)
                    {
                       int copies = Convert.ToInt16(row.Cells["LB_Qnty_col"].FormattedValue);
                       Inventory inv = (Inventory)bsOrderReceiptItems[row.Index];
                       ThermalLabel lb = lbService.GenerateInventoryLabel(inv.LineId.ToString(),
                                                   jobName,
                                                    DateTime.Today.ToShortDateString());
                       lbService.PrintLabel(lb,copies);
                       
                    }
                    
                   
                }
            }
           

        }

        private void label5_Click(object sender, EventArgs e) {

        }
    }
}

