using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Entities;
using DataLayer.Interfaces;
using AutoMapper.Configuration;
using DataLayer.Services;
using Weaselware.InventoryFerret.Wrapper;
using AutoMapper;
using Weaselware.InventoryFerret.Profiles;



namespace Weaselware.InventoryFerret
{
    public partial class DataForm : Form
    {

        UnitOfMeasure _selectedMeasure;
        IPartsService _partService;
        IOrdersService _ordersService;
        BadgerDataModel ctx;
        BindingSource bsLineItems;
        Part _selectedPart = null;
        PurchaseLineItem _selectedPurchaseLineItem = null;
        private List<PurchaseLineItemWrapper> lineItems = new List<PurchaseLineItemWrapper>();
        IMapper mapper;
        bool _isDirty = false;

        public DataForm()
        {
            InitializeComponent();
            ctx = new BadgerDataModel();
            _selectedMeasure = new UnitOfMeasure { Uid = 1, Uom = "Each" };
            _partService = new PartsService(ctx);
            _ordersService = new OrdersService(ctx);
            bsLineItems = new BindingSource();
            this.Size = new Size(800, 450);

            var config = new MapperConfiguration(cfg => {

                cfg.AddProfile<OrdersProfile>();


            });
 
            mapper = config.CreateMapper();
           
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            view.AutoGenerateColumns = false;
            view.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            view.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            InitializeGrid();
            view.CellEndEdit += View_CellEndEdit;
            view.DataError += View_DataError;
            view.CellValidating += View_CellValidating;
            view.CellValueChanged += View_CellValueChanged;
            view.CellContentClick += View_CellContentClick;
            bsLineItems.ListChanged += BsLineItems_ListChanged;
            
            btnSave.Enabled = _isDirty;
        }

        private void View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           int partNumber = int.Parse(view.Rows[e.RowIndex].Cells[1].Value.ToString());
            if (partNumber != 0)
            {
                // Open the part Editor or other action
            }
           
           
        }

        private void BsLineItems_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == System.ComponentModel.ListChangedType.ItemChanged)
            {
                _isDirty = true;
                btnSave.Enabled = _isDirty;
            }
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                _isDirty = true;
                btnSave.Enabled = _isDirty;
               
            }
        }

        private void View_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TotalOrder();
        }

        private void View_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            view.Rows[e.RowIndex].ErrorText = "";
            decimal costValue;
            decimal qntyValue;
            int partNumber;

            if (e.ColumnIndex == 1)
            {

                if (view.Rows[e.RowIndex].IsNewRow) { return; }
                if (!int.TryParse(e.FormattedValue.ToString(), 
                    out partNumber) || partNumber < 0)
                {
                    e.Cancel = true; //declare to stay in this cell - not to loose the focus!
                    view.Rows[e.RowIndex].ErrorText = "Enter valid part number or 0"; //error massage
                }
              
            }

            if (e.ColumnIndex == 2)
            {

                if (view.Rows[e.RowIndex].IsNewRow) { return; }
                if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    e.Cancel = true; //declare to stay in this cell - not to loose the focus!
                    view.Rows[e.RowIndex].ErrorText = "You must provide a reasonable description"; //error massage
                }
            }


            if (e.ColumnIndex == 4)
            { 
            
                if (view.Rows[e.RowIndex].IsNewRow) { return; }
                if (!decimal.TryParse(e.FormattedValue.ToString(), System.Globalization.NumberStyles.Currency, null,
                    out costValue) || costValue < 0) //checking if value is type of doubl or is not lower then zero (last is not needed, if you have negative numbers)
                {
                    e.Cancel = true; //declare to stay in this cell - not to loose the focus!
                    view.Rows[e.RowIndex].ErrorText = "the value must be a non-negative decimal"; //error massage
                }
            }
            if (e.ColumnIndex == 5)
            {

                if (view.Rows[e.RowIndex].IsNewRow) { return; }
                if (!decimal.TryParse(e.FormattedValue.ToString(), System.Globalization.NumberStyles.Currency, null,
                    out qntyValue) || qntyValue <= 0) //checking if value is type of doubl or is not lower then zero (last is not needed, if you have negative numbers)
                {
                    e.Cancel = true; //declare to stay in this cell - not to loose the focus!
                    view.Rows[e.RowIndex].ErrorText = "the quantity must be a non-negative decimal"; //error massage
                }
            }
            TotalOrder();
        }

        private void View_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.   
            view.Rows[e.RowIndex].ErrorText = String.Empty;
            TotalOrder();
        }


        private void View_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if(e.ColumnIndex==3)
            {
                e.ThrowException = false;

                // Display an error message.
                string txt = "Error with " +
                    view.Columns[e.ColumnIndex].HeaderText +
                    "\n\n" + e.Exception.Message;
                MessageBox.Show(txt, "Cost must be empty or null",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                e.Cancel = false;

            }
        }

        
     

        private void TotalOrder()
        {
            if (bsLineItems.DataSource != null)
            {
                decimal result = decimal.Zero;

                foreach (var item in bsLineItems)
                {
                    var l = (PurchaseLineItemWrapper)item;
                    if (l.UnitCost != null)
                    {
                        result += ((PurchaseLineItemWrapper)item).Extended;
                    }
  
                }
                this.textBox1.Text = result.ToString("C");
            }
        }


        private void InitializeGrid()
        {


            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;


            // ID Column --
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.HeaderText = "LineID";
            colID.DataPropertyName = "LineId";
            colID.Width = 75;

            // PartID Column --
            DataGridViewLinkColumn colPartID = new DataGridViewLinkColumn();
            colPartID.HeaderText = "PartID";
            colPartID.DataPropertyName = "PartId";
            colPartID.Width = 50;

            // Description Column --
            DataGridViewTextBoxColumn colDescription = new DataGridViewTextBoxColumn();
            colDescription.HeaderText = "Description";
            colDescription.DataPropertyName = "Description";
            colDescription.Width = 450;
            colDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            // Unit of Measure --
            DataGridViewComboBoxColumn colUnit = new DataGridViewComboBoxColumn();
            colUnit.Width = 60;
            colUnit.DisplayMember = "UOM";
            colUnit.ValueMember = "UID";
            colUnit.DataPropertyName = "Uom";
            // UnitCost ----------
            DataGridViewTextBoxColumn colCost = new DataGridViewTextBoxColumn();
            colCost.Width = 60;
            colCost.HeaderText = "Cost";
            colCost.DataPropertyName = "UnitCost";
            colCost.DefaultCellStyle = dstyleCurrency;

            // Qnty ----------
            DataGridViewTextBoxColumn colQnty = new DataGridViewTextBoxColumn();
            colQnty.Width = 60;
            colQnty.HeaderText = "Qnty";
            colQnty.DataPropertyName = "Qnty";

            colQnty.DefaultCellStyle = dstyleDecimal;
            // Extended ----------
            DataGridViewTextBoxColumn colExtended = new DataGridViewTextBoxColumn();

            colExtended.Width = 60;
            colExtended.HeaderText = "Extended";
            colExtended.DataPropertyName = "Extended";
            colExtended.DefaultCellStyle = dstyleCurrency;

            colUnit.DataSource = _partService.Units();
            view.Columns.AddRange( colID, colPartID, colDescription, colUnit, colCost, colQnty, colExtended);
            view.Dock = DockStyle.None;
            this.Controls.Add(view);

            BindGrid();

            bsLineItems.DataSource = lineItems;
        }

        private void BindGrid()
        {
            
            var t = _ordersService.GetOrderByID(5000).PurchaseLineItem;

            foreach (var item in t)
            {
                lineItems.Add(new PurchaseLineItemWrapper(item));
            }
            bsLineItems.DataSource = lineItems;
            view.DataSource = bsLineItems;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void SaveChanges()
        {
            ctx.SaveChanges();
            _isDirty = false;
            btnSave.Enabled = false;
            view.Rows.Clear();
            BindGrid();
            bsLineItems.ResetBindings(false);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            listBox1.DisplayMember = "ItemDescription";
            this.listBox1.DataSource = _partService.SearchParts(tb.Text, SearchOptions.Contains);
        }

        private void DataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isDirty)
            {
                if (MessageBox.Show("Do you want to save changes?", "Inventory-Ferret",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Cancel the Closing event from closing the form.
                    //e.Cancel = true;
                    // Call method to save file...
                    ctx.SaveChanges();
                 
                }
                else
                {

                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            if(lb.DataSource != null)
            {
                if (lb.Items.Count > 0)
                {
                    _selectedPart = (Part)lb.SelectedItem;
                }
            }
        }

        private void btnAddSelectedPart_Click(object sender, EventArgs e)
        {
            AddPartbyNumber(_selectedPart);
        }

        private void AddPartbyNumber(Part part)
        {
            if (part != null)
            {
                var newLine = new PurchaseLineItem
                {
                    Description = part.ItemDescription,
                    PartId = part.PartId,
                    UnitCost = part.Cost,
                    Uom = part.Uid,
                    Qnty = 1.0m,
                    Extended = 0.0m,
                    AmountReceived = 0.0m,
                    PurchaseOrderId = 5000


                };
                ctx.Entry(newLine).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                var addLine = new PurchaseLineItemWrapper(newLine);
                bsLineItems.Add(addLine);
                _isDirty = true;
                btnSave.Enabled = _isDirty;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (_selectedPurchaseLineItem != null)
            {             
                if (_selectedPurchaseLineItem.LineId != default(int))
                {
                    ctx.PurchaseLineItem.Remove(_selectedPurchaseLineItem);
                       
                }

                SaveChanges();
            }
        }

        private void view_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {
                if (dg.RowCount > 0)
                {
                  
                    if (dg.CurrentRow.DataBoundItem != null)
                    {
                        _selectedPurchaseLineItem = ((PurchaseLineItemWrapper)dg.CurrentRow.DataBoundItem).Model;
                    }

                }

            }
        }
    }
}
