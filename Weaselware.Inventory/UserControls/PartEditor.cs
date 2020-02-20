using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Entities;
using DataLayer.Services;
using DataLayer.Interfaces;
using Neodynamic.SDK.Printing;
using System.Text.RegularExpressions;


namespace Weaselware.InventoryFerret
{
    public partial class PartEditor : UserControl
    {
        BadgerDataModel _context;
        IPartsService partsService;
        LabelService labelService;
        BindingSource bsPartsListSource = new BindingSource();
        SearchOptions searchOption;
        string searchTerm;
        private Part selectedPart;
        BarCodeReader reader = new BarCodeReader();
        string foundBarCode;
        ScanType _scanType;

        enum ScanType
        {
            find,
            associate
        }

        public PartEditor(BadgerDataModel ctx)
        {
            InitializeComponent();
            dgPartsList.AutoGenerateColumns = false;
            _context = ctx;
            partsService = new PartsService(_context);
            labelService = new LabelService();

        }

        private void PartEditor_Load(object sender, EventArgs e)
        {
            searchOption = SearchOptions.Contains;
            dgPartsList.DataSource = bsPartsListSource;
            reader.OnBarCodeRead += Reader_OnBarCodeRead;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPartSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            searchTerm = tb.Text;
            if (tb.Text.Length > 0)
            {
                dgPartsList.DataSource = partsService.SearchParts(searchTerm, searchOption);

            }
        }

        private void rbContains_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                searchOption = SearchOptions.Contains;
                bsPartsListSource.DataSource = partsService.SearchParts(searchTerm, searchOption);
            }
            else if (rb.Checked != true)
            {
                searchOption = SearchOptions.StartsWith;
                bsPartsListSource.DataSource = partsService.SearchParts(searchTerm, searchOption);
            }
        }

        private void btnEditPart_Click(object sender, EventArgs e)
        {
            if (dgPartsList.DataSource != null)
            {
                if (dgPartsList.SelectedRows.Count > 0)
                {
                    PartForm partForm = new PartForm();
                    if (selectedPart != null)
                    {
                        PartView partView = new PartView(selectedPart, _context);

                        partForm.Controls.Add(partView);
                        partView.Dock = DockStyle.Fill;
                        partForm.Show();
                    }


                }
            }
        }

        private void btnCreateNewPart_Click(object sender, EventArgs e)
        {
            PartForm partForm = new PartForm();
            IPartsService partService = new PartsService(_context);
            Part part = partsService.New();

            PartView partView = new PartView(part, _context);
            partForm.Controls.Add(partView);
            partView.Dock = DockStyle.Fill;
            partForm.Show();
        }

        private void dgPartsList_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dv = (DataGridView)sender;
            if (dgPartsList.DataSource != null)
            {
                if (dgPartsList.SelectedRows.Count > 0)
                {
                    selectedPart = (Part)dv.CurrentRow.DataBoundItem;
                }
            }
        }

        private void dgPartsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dv = (DataGridView)sender;
            if (dgPartsList.DataSource != null)
            {
                if (dgPartsList.SelectedRows.Count > 0)
                {
                    selectedPart = (Part)dv.CurrentRow.DataBoundItem;

                    
                    PartForm partForm = new PartForm();
                    if (selectedPart != null)
                    {
                        PartView partView = new PartView(selectedPart, _context);
                        partView.HostForm = partForm;
                        partForm.Controls.Add(partView);
                        partView.Dock = DockStyle.Fill;
                        partForm.Show();
                    }

                }
            }
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            TabPage tabpage = (TabPage)this.Parent;
            TabControl tabControl = (TabControl)tabpage.Parent;
            tabControl.TabPages.Remove(tabpage);
        }

        private void btnAssociateSKU_Click(object sender, EventArgs e)
        {
            _scanType = ScanType.associate;
            reader.OpenScanner();
           
        }

        private void Reader_OnBarCodeRead(object sender, BarCodeReader.BarCodeReadEventArgs e)
        {

            InventoryService iService = new InventoryService(_context);
            Regex reg = null;

            reg = new System.Text.RegularExpressions.Regex("^[1-9][0-9]*$");
            foundBarCode = string.Empty;
            Invoke(new MethodInvoker(() => { txtScannerOutput.Text = e.ValueRead.ToString(); }));
            Invoke(new MethodInvoker(() => { foundBarCode = e.ValueRead.ToString(); }));
            if (txtScannerOutput.Text != string.Empty)
            {


                if (selectedPart != null  && _scanType == ScanType.associate)
                {
                    partsService.AssociateSKU(selectedPart, foundBarCode);
                    var _part = partsService.Find(selectedPart.PartId);
                    if (_part.Sku == foundBarCode)
                    {
                        MessageBox.Show("Success Associating SKU to Part");
                       
                        Invoke(new MethodInvoker(() => { this.txtPartSearch.Text = " "; }));
                    }
                    return;

                }
                else if(_scanType == ScanType.find)
                {
                    Part partlookup = partsService.FindBySKU(foundBarCode);
                    if (!String.IsNullOrEmpty(partlookup.Sku))
                    {
                        reader.CloseScanner();
                        Invoke(new MethodInvoker(() => { OpenPartDetailForm(partlookup.PartId , _context); ; }));
                    }
                    }
                }


            }


        public void OpenPartDetailForm(int partID, BadgerDataModel ctx)
        {
            Part partlookup = partsService.Find(partID);
            if (!String.IsNullOrEmpty(partlookup.Sku))
            {
                PartForm partForm = new PartForm();
                if (partlookup != null)
                {
                    PartView partView = new PartView(partlookup, ctx);
                    partView.HostForm = partForm;
                    partForm.Controls.Add(partView);
                    partView.Dock = DockStyle.Fill;
                    partForm.Show();

                    
                }
            }
        }


        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFindBySKU_Click(object sender, EventArgs e)
        {

            _scanType = ScanType.find; 
            reader.OpenScanner();

           
        }
        // Print a Barcoded Label for the part
        private void button1_Click(object sender, EventArgs e)
        {
            LabelService lbService = new LabelService();
            //string jobName = oService.GetOrderByID(_receipt.OrderNum.Value).Job.jobname;
            if (selectedPart != null)
            {
                ThermalLabel partLabel = labelService.GeneratePartLabel(selectedPart.PartId.ToString(),selectedPart.ItemDescription);
                lbService.PrintLabel(partLabel, 1);
            }

        }
    }
    
}
