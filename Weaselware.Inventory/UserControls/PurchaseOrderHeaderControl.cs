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

        //OrderDetailDto _purchaseOrder;
        BindingSource _purchaseOrder;
        private  decimal _TaxRate;

        //public OrderDetailDto PurchaseOrder { get => _purchaseOrder; set => _purchaseOrder = value; }
        public BindingSource PurchaseOrder { get => _purchaseOrder; set => _purchaseOrder = value; }


        public PurchaseOrderHeaderControl()
        {
            InitializeComponent();
            _TaxRate = Weaselware.InventoryFerret.Properties.Settings.Default.Taxrate;
        }

        //// Changed to using BindingSource ---
        public void SetDataSource(BindingSource purchaseOrder)
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
            txtOrderNumber.DataBindings.Add("Text", PurchaseOrder, "PurchaseOrderID", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier Name -------------------------------------------------------
            txtSupplierName.DataBindings.Clear();
            txtSupplierName.DataBindings.Add("Text", PurchaseOrder, "SupplierName", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier Address -------------------------------------------------------
            txtSupplierAddress.DataBindings.Clear();
            txtSupplierAddress.DataBindings.Add("Text", PurchaseOrder, "SupplierAddress", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier City -------------------------------------------------------
            txtCity.DataBindings.Clear();
            txtCity.DataBindings.Add("Text", PurchaseOrder, "SupplierCity", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier State -------------------------------------------------------
            txtState.DataBindings.Clear();
            txtState.DataBindings.Add("Text", PurchaseOrder, "SupplierState", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier Zip -------------------------------------------------------
            txtZip.DataBindings.Clear();
            txtZip.DataBindings.Add("Text", PurchaseOrder, "SupplierZip", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier Phone -------------------------------------------------------
            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add("Text", PurchaseOrder, "SupplierPhone", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier Fax -------------------------------------------------------
            txtFax.DataBindings.Clear();
            txtFax.DataBindings.Add("Text", PurchaseOrder, "SupplierFax", true, DataSourceUpdateMode.OnPropertyChanged);
            // Purchaser -------------------------------------------------------
            txtPurchaser.DataBindings.Clear();
            txtPurchaser.DataBindings.Add("Text", PurchaseOrder, "Purchaser", true, DataSourceUpdateMode.OnPropertyChanged);
            // Order Date -------------------------------------------------------
            txtOrderDate.DataBindings.Clear();
            txtOrderDate.DataBindings.Add("Text", PurchaseOrder, "OrderDate", true, DataSourceUpdateMode.OnPropertyChanged);
            // Order Total -------------------------------------------------------
            txtOrderTotal.DataBindings.Clear();
            txtOrderTotal.DataBindings.Add("Text", PurchaseOrder, "OrderTotal", true, DataSourceUpdateMode.OnPropertyChanged,0.0,"C");
            // SubTotal
            txtSubTotal.DataBindings.Clear();
            txtSubTotal.DataBindings.Add("Text", PurchaseOrder, "SubTotal", true, DataSourceUpdateMode.OnPropertyChanged,0.0,"C");
            // Tax -------------------------------------------------------
            txtTax.DataBindings.Clear();
            txtTax.DataBindings.Add("Text", PurchaseOrder, "Tax", true, DataSourceUpdateMode.OnPropertyChanged, 0.0, "C");
            // Memo ---------------------------------------------------------------------------------------------
            txtMemo.DataBindings.Clear();
            txtMemo.DataBindings.Add("Text", PurchaseOrder, "Memo", true, DataSourceUpdateMode.OnPropertyChanged);
            // Rep
            txtAttention.DataBindings.Clear();
            txtAttention.DataBindings.Add("Text", PurchaseOrder, "SalesRep", true, DataSourceUpdateMode.OnPropertyChanged);
            // Taxable
            cbTaxable.DataBindings.Clear();
            cbTaxable.DataBindings.Add("Checked", PurchaseOrder, "Taxable", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
