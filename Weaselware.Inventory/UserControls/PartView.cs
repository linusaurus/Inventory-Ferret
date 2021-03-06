﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Entities;
using DataLayer.Interfaces;
using DataLayer.Services;
using DataLayer.Models;
using System.Collections;

namespace Weaselware.InventoryFerret
{
    public partial class PartView : UserControl
    {
        BindingSource bsPart = new BindingSource();
        Part _part;
        BadgerDataModel _context;
        public Form HostForm { get; set; }
        private List<Document> _documents;

        BindingSource bsDocuments = new BindingSource();
        BarCodeReader barCodeReader = new BarCodeReader();
        IPartsService partsService;
        IInventoryService inventoryService;
        DataView transactionsView;

        private bool _isDirty = false;

        BindingSource bsTransactions = new BindingSource();
        /// <summary>
        /// TODO  use PartID and DTO to hydrate the control
        /// </summary>
        /// <param name="part"></param>
        /// <param name="ctx"></param>
        public PartView(Part part, BadgerDataModel ctx)
        {
            InitializeComponent();
            _context = ctx;
            ISuppliersService var = new SuppliersService(_context);
            inventoryService = new InventoryService(_context);
            partsService = new PartsService(_context);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dgvTransactions.AutoGenerateColumns = false;
            if (part.PartID > 0)
            {
              _part = partsService.Find(part.PartID);                             
            }
            else
            {
                _part = partsService.New();
                _part.AddedBy = Globals.CurrentUserName;
                _part.DateAdded = DateTime.Today;
            }        
            cboSuppliers.DisplayMember = "SupplierName";
            cboSuppliers.ValueMember = "SupplierID";
            cboSuppliers.SelectedItem = _part.SupplierId;
            cboSuppliers.DataSource = var.GetAll();

            cboUnits.DisplayMember = "UOM";
            cboUnits.ValueMember = "UID";
            cboUnits.SelectedItem = _part.UID;
            cboUnits.DataSource = partsService.Units();

            cboManus.DisplayMember = "Manufacturer";
            cboManus.ValueMember = "ManuID";
            cboManus.SelectedItem = _part.ManuId;
            cboManus.DataSource = partsService.Manufacturers();
          
           
            bsPart.DataSource = _part;
            
            // This triggers the Save Button On changed--
            bsPart.CurrentItemChanged += BsPart_CurrentItemChanged;
            
            this.btnSave.Enabled = _isDirty;
            this.txtSupplierDesc.Enabled = false;
            _documents = _context.Document.Where(r => r.PartID == _part.PartID).ToList();
           // _documents = _part.Document.ToList();
            bsDocuments.DataSource = _documents;
            this.dataGridView1.DataSource = bsDocuments;

            LoadTransaction();
            
            this.rbRecieved.Checked = true;
        }

        private void LoadTransaction()
        {
            if (_part.PartID != 0)
            {
                transactionsView = DataBuilders.BuildDataTable(inventoryService.GetInventoryByPartID(_part.PartID)).DefaultView;
                bsTransactions.DataSource = transactionsView;

                this.dgvTransactions.DataSource = bsTransactions;
                var sum = transactionsView.Table.AsEnumerable().Sum(x => x.Field<decimal>(5));
                this.txtStockOnHand.Text = sum.ToString();
            }
            
        }

       


    

        private void BsPart_CurrentItemChanged(object sender, EventArgs e)
        {
            _isDirty = true;
            btnSave.Enabled = _isDirty;

            
        }

        private void PartView_Load(object sender, EventArgs e)
        { BindPart(bsPart); }

        void BindPart(BindingSource bs)
        {
            if (_part.PartID != 0)
            {((Form)this.TopLevelControl).Text = "Part Edit : " + _part.PartID.ToString();}
            else
            {((Form)this.TopLevelControl).Text = "Part Edit : New"; }
                            
            this.txtDescription.DataBindings.Add(
                "Text", bsPart, "ItemDescription",true,DataSourceUpdateMode.OnPropertyChanged);
            this.txtSupplierDesc.DataBindings.Add(
                "Text", bsPart, "SupplierDescription", true, DataSourceUpdateMode.OnPropertyChanged);
            this.txtUnitPrice.DataBindings.Add(
                "Text", bsPart, "Cost", true, DataSourceUpdateMode.OnPropertyChanged);
            this.txtSKU.DataBindings.Add(
                "Text", bsPart, "SKU", true, DataSourceUpdateMode.OnPropertyChanged);
            this.txtPartName.DataBindings.Add(
               "Text", bsPart, "PartNum", true, DataSourceUpdateMode.OnPropertyChanged);
            // Combos ----------------------------------------------------------------------------
            this.cboSuppliers.DataBindings.Add(
                "SelectedValue", bsPart, "SupplierID", true, DataSourceUpdateMode.OnPropertyChanged);
              this.ckbUseSupplierDesc.DataBindings.Add(
                "Checked", bsPart, "UseSupplierNameFlag", true, DataSourceUpdateMode.OnPropertyChanged);
            this.cboUnits.DataBindings.Add(
                "SelectedValue", bsPart, "UID", true, DataSourceUpdateMode.OnPropertyChanged);
            this.cboManus.DataBindings.Add(
                "SelectedValue", bsPart, "ManuID", true, DataSourceUpdateMode.OnPropertyChanged);
            // ------------------------------------------------------------------------------------
            this.txtWeight.DataBindings.Add("Text", bsPart, "Weight", true, DataSourceUpdateMode.OnPropertyChanged);
            this.txtMarkup.DataBindings.Add("Text", bsPart, "MarkUp", true, DataSourceUpdateMode.OnPropertyChanged);
            this.txtWaste.DataBindings.Add("Text", bsPart, "Waste", true, DataSourceUpdateMode.OnPropertyChanged);
            this.txtLocation.DataBindings.Add("Text", bsPart, "Location", true, DataSourceUpdateMode.OnPropertyChanged);


            //----------------------------------------------------------------------------------------
            this.txtSupplierDesc.DataBindings.Add(
                "Enabled", bsPart, "UseSupplierNameFlag", true, DataSourceUpdateMode.OnPropertyChanged);
            this.ckbCarbTrack.DataBindings.Add(
                "Checked", bsPart, "CARBtrack", true, DataSourceUpdateMode.OnPropertyChanged);
            //-----------------------------------------------------------------------
            this.txtBoilingPoint.DataBindings.Add(
              "Visible", bsPart, "CARBtrack", true, DataSourceUpdateMode.OnPropertyChanged);
            this.txtMixRatio.DataBindings.Add(
              "Visible", bsPart, "CARBtrack", true, DataSourceUpdateMode.OnPropertyChanged);
            this.txtVOCcontent.DataBindings.Add(
              "Visible", bsPart, "CARBtrack", true, DataSourceUpdateMode.OnPropertyChanged);
            this.txtVOCLimit.DataBindings.Add(
              "Visible", bsPart, "CARBtrack", true, DataSourceUpdateMode.OnPropertyChanged);
            // --------------------Associated Labels ----------------------------------------
            this.labelBoilingPoint.DataBindings.Add("Visible", bsPart, "CARBtrack", true, DataSourceUpdateMode.OnPropertyChanged);
            this.lblMixRatio.DataBindings.Add("Visible", bsPart, "CARBtrack", true, DataSourceUpdateMode.OnPropertyChanged);
            this.lblVOCcontent.DataBindings.Add("Visible", bsPart, "CARBtrack", true, DataSourceUpdateMode.OnPropertyChanged);
            this.lblVOCLimits.DataBindings.Add("Visible", bsPart, "CARBtrack", true, DataSourceUpdateMode.OnPropertyChanged);
            //Resources Grid


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TabPage tabpage = (TabPage)this.Parent;
            TabControl tabControl = (TabControl)tabpage.Parent;
            tabControl.TabPages.Remove(tabpage);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
               
            // If the part is new-detached
           if (_context.Entry(_part).State == EntityState.Detached)
           { 
                _context.Part.Add(_part); 
           }

           // Date and Name stamp modifications --
            var user = Globals.CurrentLoggedUserID;
           
            _part.ModifiedBy = Globals.CurrentUserName;
            _part.ModifiedDate = DateTime.Today;
            //-------------------------------------
            _context.SaveChanges();

            _isDirty = false;
            TabPage tabpage = (TabPage)this.Parent;
            TabControl tabControl = (TabControl)tabpage.Parent;
            tabControl.TabPages.Remove(tabpage);

        }

        // Validation -------##
        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (string.IsNullOrEmpty(tb.Text) )
            {
                //errDescription.Icon = (Icon)Properties.Resources.mailicon;
                errDescription.SetIconAlignment(tb, ErrorIconAlignment.TopLeft);
                errDescription.SetError(tb, "Parts must have a description");
            }
            else
            {
                errDescription.SetError(tb, string.Empty);
            }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            if (!_isDirty)
            {
                TabPage tabpage = (TabPage)this.Parent;
                TabControl tabControl = (TabControl)tabpage.Parent;
                tabControl.TabPages.Remove(tabpage);
            }
            else
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Save changes before closing?";
                string caption = "Unsaved Changes";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    var user = Globals.CurrentLoggedUserID;
                    //string username = _context.Employee.Find(user)?.Firstname ?? "Unknown User";
                    _part.ModifiedBy = Globals.CurrentUserName;
                    _part.ModifiedDate = DateTime.Today;
                    //-------------------------------------
                    _context.SaveChanges();
                    TabPage tabpage = (TabPage)this.Parent;
                    TabControl tabControl = (TabControl)tabpage.Parent;
                    tabControl.TabPages.Remove(tabpage);

                }
                else
                {
                    bsPart.CancelEdit();
                    TabPage tabpage = (TabPage)this.Parent;
                    TabControl tabControl = (TabControl)tabpage.Parent;
                    tabControl.TabPages.Remove(tabpage);
                }
            }

        }

    
        private void btnAddResource_Click(object sender, EventArgs e)
        {
            //NewResourceForm form = new NewResourceForm(_part.PartID);
            //if(form.ShowDialog() == DialogResult.OK)
            //{

            //}
            //else 
            //{

            //}
           // partsService.AddResource();
        }

        private void ckbCarbTrack_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtLocation_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Trim().Length > 6)
            {
               
                errDescription.SetIconAlignment(tb, ErrorIconAlignment.TopLeft);
                errDescription.SetError(tb, "Location Can Only be 6 Characters");
            }
            else
            {
                errDescription.SetError(tb, string.Empty);
            }
        }

        private void btnScanSKU_Click(object sender, EventArgs e)
        {
            try
            {             
                barCodeReader.OpenScanner();
            }
            catch (Exception)
            {
                return;
            }
            
            barCodeReader.OnBarCodeRead += Reader_OnBarCodeRead;
        }

        private void Reader_OnBarCodeRead(object sender, BarCodeReader.BarCodeReadEventArgs e)
        {


            IPartsService partService = new PartsService(_context);
            string foundBarCode = e.ValueRead.ToString();

            if (foundBarCode != string.Empty)
            {
                if (_part != null)
                {
                    _part.Sku = foundBarCode;
                    //Invoke(new MethodInvoker(() => { this.propertyGrid1.SelectedObject = inv; }));
                     Invoke(new MethodInvoker(() => { this.txtSKU.Text = foundBarCode; }));
                }
                else
                {
                    //  Invoke(new MethodInvoker(() => { this.propertyGrid1.SelectedObject = null; }));
                    Invoke(new MethodInvoker(() => { this.txtSKU.Text = String.Empty; }));                 
                }

                barCodeReader.OnBarCodeRead -= Reader_OnBarCodeRead;
            }

        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {
                if (dg.RowCount > 0)
                {
                    if (dg.CurrentRow.DataBoundItem != null)
                    {
                        if (e.ColumnIndex == 0)
                        {
                         
                         var key =  dg.CurrentRow.Cells[0];

                        }
                    }

                }
            }
        }

        private void rbRecieved_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (_part.PartID != 0)
            {         
                if (rb.Checked | rb.Name=="rbReceived")
                {
                    bsTransactions.Filter = "TransactionType = '1' OR TransactionType = '4'";
                    DataView view = ((DataView)bsTransactions.DataSource);
                    txtTransCalc.Text = view.Table.DefaultView.Table.Compute("SUM(QntyRev)", "TransactionType = '1' OR TransactionType = '4'").ToString();
                }
            }
           
        }

        private void rbUsed_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked | rb.Name == "rbUsed")
            {
                bsTransactions.Filter = "TransactionType = '4' OR TransactionType = '3' ";
                DataView view  = ((DataView)bsTransactions.DataSource);
                txtTransCalc.Text = view.Table.DefaultView.Table.Compute("SUM(QntyRev)", "TransactionType = '4' OR TransactionType = '3'").ToString();
               
                
            }

        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked | rb.Name == "rbAll")
            {
                bsTransactions.Filter = "TransactionType = '4' OR TransactionType = '3' OR TransactionType = '1' OR TransactionType = '2'";
                DataView view = ((DataView)bsTransactions.DataSource);
                txtTransCalc.Text = view.Table.DefaultView.Table
                    .Compute("SUM(QntyRev)", "TransactionType = '4' OR TransactionType = '3' OR TransactionType = '1' OR TransactionType = '2'").ToString();

            }
        }

        private void txtStockOnHand_TextChanged(object sender, EventArgs e)
        {

        }

        #region Stock Actions

        private void btnPullStock_Click(object sender, EventArgs e)
        {
            if (_part != null)
            {
                inventoryService.PullStock(_part.PartID, 1.2m, Globals.CurrentLoggedUserID);
                LoadTransaction();
            }
        }

        private void btnSetLevel_Click(object sender, EventArgs e)
        {
            if (_part != null)
            {
                inventoryService.SetStock(_part.PartID, 20.0m, Globals.CurrentLoggedUserID);
                LoadTransaction();
            }
        }

        #endregion

       
    }
}
