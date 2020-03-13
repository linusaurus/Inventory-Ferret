using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
//using BadgerData;
using DataLayer.Entities;
using DataLayer.Models;
using Boxed.Mapping;

namespace Weaselware.InventoryFerret
{
    public partial class PurchaseOrderHeaderControl : UserControl
    {

        OrderDetailDto _purchaseOrder;
        private  decimal _TaxRate;

        public OrderDetailDto PurchaseOrder { get => _purchaseOrder; set => _purchaseOrder = value; }

        public PurchaseOrderHeaderControl()
        {
            InitializeComponent();
            _TaxRate = Weaselware.InventoryFerret.Properties.Settings.Default.Taxrate;
        }

     

        public void SetDataSource(OrderDetailDto purchaseOrder)
        {
            PurchaseOrder = purchaseOrder;
            Bind();
        }

        private void PurchaseOrderHeaderControl_Load(object sender, EventArgs e)
        {

        }

        private void Bind()
        {
            // Order Number -------------------------------------------------------
            txtOrderNumber.DataBindings.Clear();
            txtOrderNumber.DataBindings.Add("Text", PurchaseOrder, "PurchaseOrderID");
            // Supplier Name -------------------------------------------------------
            txtSupplierName.DataBindings.Clear();
            txtSupplierName.DataBindings.Add("Text", PurchaseOrder, "SupplierName");
            // Supplier Address -------------------------------------------------------
            txtSupplierAddress.DataBindings.Clear();
            txtSupplierAddress.DataBindings.Add("Text", PurchaseOrder, "SupplierAddress");
            // Supplier City -------------------------------------------------------
            txtCity.DataBindings.Clear();
            txtCity.DataBindings.Add("Text", PurchaseOrder, "SupplierCity");
            // Supplier State -------------------------------------------------------
            txtState.DataBindings.Clear();
            txtState.DataBindings.Add("Text", PurchaseOrder, "SupplierState");
            // Supplier Zip -------------------------------------------------------
            txtZip.DataBindings.Clear();
            txtZip.DataBindings.Add("Text", PurchaseOrder, "SupplierZip");
            // Supplier Phone -------------------------------------------------------
            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add("Text", PurchaseOrder, "SupplierPhone");
            // Supplier Fax -------------------------------------------------------
            txtFax.DataBindings.Clear();
            txtFax.DataBindings.Add("Text", PurchaseOrder, "SupplierFax");
            // Purchaser -------------------------------------------------------
            txtPurchaser.DataBindings.Clear();
            txtPurchaser.DataBindings.Add("Text", PurchaseOrder, "Purchaser");
            // Order Date -------------------------------------------------------
            txtOrderDate.DataBindings.Clear();
            txtOrderDate.DataBindings.Add("Text", PurchaseOrder, "OrderDate");
            // Order Total -------------------------------------------------------
            txtOrderTotal.DataBindings.Clear();
            txtOrderTotal.DataBindings.Add("Text", PurchaseOrder, "OrderTotal");
            // Order Total -------------------------------------------------------
            txtTax.DataBindings.Clear();
            txtTax.DataBindings.Add("Text", PurchaseOrder, "Tax");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                PurchaseOrder.Tax = _purchaseOrder.OrderTotal * _TaxRate;
                Bind();
            }
            else
            {
                PurchaseOrder.Tax = 0.0m;
                Bind();
            }
        }
    }
}
