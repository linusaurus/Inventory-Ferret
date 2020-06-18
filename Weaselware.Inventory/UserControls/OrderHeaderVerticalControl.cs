﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weaselware.InventoryFerret.UserControls
{
    public partial class OrderHeaderVerticalControl : UserControl
    {
        
        private BindingSource bsorder = new BindingSource();
       
        public event EventHandler  OnSaveHandler;
        public event EventHandler OnPrintHandler;

      
        protected virtual void OnSave(EventArgs e)
        {
            if (OnSaveHandler != null)
            {OnSaveHandler(this, e);}
        }

        protected virtual void OnPrint(EventArgs e)
        {
            if (OnPrintHandler != null)
            {
                OnPrintHandler(this, e);
            }
        }
    
        
        public OrderHeaderVerticalControl()
        {
            InitializeComponent();
        }

        public void LoadDataSource(BindingSource BSorder)
        {
            bsorder = BSorder;
            Bind();
        }

       
        
        private void Bind()
        {
            // Order Number -------------------------------------------------------
            txtOrderNumber.DataBindings.Clear();
            txtOrderNumber.DataBindings.Add("Text", bsorder, "PurchaseOrderID", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier Name -------------------------------------------------------
            txtSupplierName.DataBindings.Clear();
            txtSupplierName.DataBindings.Add("Text", bsorder, "SupplierName", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier Address -------------------------------------------------------
            txtSupplierAddress.DataBindings.Clear();
            txtSupplierAddress.DataBindings.Add("Text", bsorder, "SupplierAddress", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier City -------------------------------------------------------
            txtCity.DataBindings.Clear();
            txtCity.DataBindings.Add("Text", bsorder, "SupplierCity", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier State -------------------------------------------------------
            txtState.DataBindings.Clear();
            txtState.DataBindings.Add("Text", bsorder, "SupplierState", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier Zip -------------------------------------------------------
            txtZip.DataBindings.Clear();
            txtZip.DataBindings.Add("Text", bsorder, "SupplierZip", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier Phone -------------------------------------------------------
            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add("Text", bsorder, "SupplierPhone", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier Fax -------------------------------------------------------
            txtFax.DataBindings.Clear();
            txtFax.DataBindings.Add("Text", bsorder, "SupplierFax", true, DataSourceUpdateMode.OnPropertyChanged);
            // Purchaser -------------------------------------------------------
            txtPurchaser.DataBindings.Clear();
            txtPurchaser.DataBindings.Add("Text", bsorder, "Purchaser", true, DataSourceUpdateMode.OnPropertyChanged);
            // Order Date -------------------------------------------------------
            txtOrderDate.DataBindings.Clear();
            txtOrderDate.DataBindings.Add("Text", bsorder, "OrderDate", true, DataSourceUpdateMode.OnPropertyChanged);
            // Order Total -------------------------------------------------------
            txtOrderTotal.DataBindings.Clear();
            txtOrderTotal.DataBindings.Add("Text", bsorder, "OrderTotal", true, DataSourceUpdateMode.OnPropertyChanged, 0.0, "C");
            // SubTotal
            txtSubTotal.DataBindings.Clear();
            txtSubTotal.DataBindings.Add("Text", bsorder, "SubTotal", true, DataSourceUpdateMode.OnPropertyChanged, 0.0, "C");
            // Tax -------------------------------------------------------
            txtTax.DataBindings.Clear();
            txtTax.DataBindings.Add("Text", bsorder, "Tax", true, DataSourceUpdateMode.OnPropertyChanged, 0.0, "C");
            // Memo ---------------------------------------------------------------------------------------------
            txtMemo.DataBindings.Clear();
            txtMemo.DataBindings.Add("Text", bsorder, "Memo", true, DataSourceUpdateMode.OnPropertyChanged);
            // Rep
            txtAttention.DataBindings.Clear();
            txtAttention.DataBindings.Add("Text", bsorder, "SalesRep", true, DataSourceUpdateMode.OnPropertyChanged);
            // Taxable
            cbTaxable.DataBindings.Clear();
            cbTaxable.DataBindings.Add("Checked", bsorder, "Taxable", true, DataSourceUpdateMode.OnPropertyChanged);
            // SHipping and Fees
            txtOtherFees.DataBindings.Clear();
            txtOtherFees.DataBindings.Add("Text", bsorder, "ShippingCost", true, DataSourceUpdateMode.OnPropertyChanged, 0.0, "C");
            // Jobname --
            txtJobName.DataBindings.Clear();
            txtJobName.DataBindings.Add("Text", bsorder, "JobName", true, DataSourceUpdateMode.OnPropertyChanged);
            // Taxrate
            txtTaxRate.DataBindings.Clear();
            txtTaxRate.DataBindings.Add("Text", bsorder, "TaxRate", true, DataSourceUpdateMode.OnPropertyChanged,0.0,"P");

        }

     

        private void btnSave_Click(object sender, EventArgs e)
        {
            OnSaveHandler(this,e);
            // if the return value is true
            btnSave.Enabled = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            OnPrintHandler(this, e);
        }
    }
}
