using System;
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
        BindingSource bsTransactions = new BindingSource();

        public PartView(Part part, BadgerDataModel ctx)
        {
            InitializeComponent();
            _context = ctx;
            ISuppliersService var = new SuppliersService(_context);
            inventoryService = new InventoryService(_context);
            partsService = new PartsService(_context);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dgvTransactions.AutoGenerateColumns = false;
            if (part.PartId > 0)
            {
              _part = partsService.Find(part.PartId);                             
            }
            else
            {
                _part = partsService.New();
            }        
            cboSuppliers.DisplayMember = "SupplierName";
            cboSuppliers.ValueMember = "SupplierID";
            cboSuppliers.SelectedItem = _part.SupplierId;
            cboSuppliers.DataSource = var.GetAll();

            cboUnits.DisplayMember = "UOM";
            cboUnits.ValueMember = "UID";
            cboUnits.SelectedItem = _part.Uid;
            cboUnits.DataSource = partsService.Units();

            cboManus.DisplayMember = "Manufacturer";
            cboManus.ValueMember = "ManuID";
            cboManus.SelectedItem = _part.ManuId;
            cboManus.DataSource = partsService.Manufacturers();
          
           
            bsPart.DataSource = _part;
            
            // This triggers the Save Button On changed--
            bsPart.CurrentItemChanged += BsPart_CurrentItemChanged;
            this.btnSave.Enabled = false;
            this.txtSupplierDesc.Enabled = false;
            _documents = _context.Document.Where(r => r.PartId == _part.PartId).ToList();
           // _documents = _part.Document.ToList();
            bsDocuments.DataSource = _documents;
            this.dataGridView1.DataSource = bsDocuments;

            transactionsView = DataBuilders.BuildDataTable( inventoryService.GetInventoryByPartID(_part.PartId)).DefaultView;
            bsTransactions.DataSource = transactionsView;
            
            this.dgvTransactions.DataSource = bsTransactions;
            var sum = transactionsView.Table.AsEnumerable().Sum(x => x.Field<decimal>(5));
            this.txtStockOnHand.Text = sum.ToString();
            this.rbRecieved.Checked = true;
        }

        private void BsPart_CurrentItemChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            //this.ParentForm.Text = 
        }

        private void PartView_Load(object sender, EventArgs e)
        { BindPart(bsPart); }

        void BindPart(BindingSource bs)
        {
            if (_part.PartId != 0)
            {((Form)this.TopLevelControl).Text = "Part Edit : " + _part.PartId.ToString();}
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
        {((Form)this.TopLevelControl).Close();}

        private void btnSave_Click(object sender, EventArgs e)
        {
               
            // If the part is new-detached
           if (_context.Entry(_part).State == EntityState.Detached)
           { 
                _context.Part.Add(_part); 
            }
           // Date and Name stamp modifications --
            var user = Globals.CurrentLoggedUserID;
            string username = _context.Employee.Find(user)?.Firstname ?? "Unknown User";
            _part.ModifiedBy = username;
            _part.ModifiedDate = DateTime.Today;
            //-------------------------------------
            _context.SaveChanges();
            { ((Form)this.TopLevelControl).Close(); }
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
            TabPage tabpage = (TabPage)this.Parent;
            TabControl tabControl = (TabControl)tabpage.Parent;
            tabControl.TabPages.Remove(tabpage);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAddResource_Click(object sender, EventArgs e)
        {
            NewResourceForm form = new NewResourceForm(_part);
            if(form.ShowDialog() == DialogResult.OK)
            {

            }
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
            if (rb.Checked | rb.Name=="rbReceived")
            {
                bsTransactions.Filter ="TransactionType = '1'";
                DataView view = ((DataView)bsTransactions.DataSource);
                txtTransCalc.Text = view.Table.DefaultView.Table.Compute("SUM(QntyRev)", "TransactionType = '1' ").ToString();
            }

           
        }

        private void rbUsed_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked | rb.Name == "rbUsed")
            {
                bsTransactions.Filter = "TransactionType = '4' ";
                DataView view  = ((DataView)bsTransactions.DataSource);
                txtTransCalc.Text = view.Table.DefaultView.Table.Compute("SUM(QntyRev)", "TransactionType = '4' ").ToString();
               
                
            }

        }

        private void txtStockOnHand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
