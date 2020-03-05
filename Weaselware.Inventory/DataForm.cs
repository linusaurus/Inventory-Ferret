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
        private List<PurchaseLineItemWrapper> lineItems = new List<PurchaseLineItemWrapper>();
        IMapper mapper;

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
            view.EditingControlShowing += View_EditingControlShowing;
            

        }

        private void View_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (view.CurrentCell.ColumnIndex == 1)
            {
                TextBox tb = (TextBox)e.Control;
                tb.TextChanged += new EventHandler(tb_TextChanged);
            }
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
               TextBox tb = (TextBox) sender;
                string str = tb.Text;
                //string str = view.CurrentRow.Cells[1].FormattedValue.ToString();
                //if (str != "")
                //{
                //    listBox1.DisplayMember = "ItemDescription";
                //    this.listBox1.DataSource = _partService.SearchParts(str, SearchOptions.Contains);
                //}
            
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
            // Don't try to validate the 'new row' until finished 
            // editing since there
            // is not any point in validating its initial value.

            //if (e.ColumnIndex == 1)
            //{

            //    if (view.Rows[e.RowIndex].IsNewRow) { return; }
            //    if (String.IsNullOrEmpty(e.FormattedValue.ToString()) || e.FormattedValue.ToString().Length < 10)
            //    {
            //        e.Cancel = true; //declare to stay in this cell - not to loose the focus!
            //        view.Rows[e.RowIndex].ErrorText = "you must provide a description more than 10 characters"; //error massage
            //    }

          
            //}

            if (e.ColumnIndex == 3)
            { 
            
                if (view.Rows[e.RowIndex].IsNewRow) { return; }
                if (!decimal.TryParse(e.FormattedValue.ToString(), System.Globalization.NumberStyles.Currency, null,
                    out costValue) || costValue < 0) //checking if value is type of doubl or is not lower then zero (last is not needed, if you have negative numbers)
                {
                    e.Cancel = true; //declare to stay in this cell - not to loose the focus!
                    view.Rows[e.RowIndex].ErrorText = "the value must be a non-negative decimal"; //error massage
                }
            }
            if (e.ColumnIndex == 4)
            {

                if (view.Rows[e.RowIndex].IsNewRow) { return; }
                if (!decimal.TryParse(e.FormattedValue.ToString(), System.Globalization.NumberStyles.Currency, null,
                    out qntyValue) || qntyValue <= 0) //checking if value is type of doubl or is not lower then zero (last is not needed, if you have negative numbers)
                {
                    e.Cancel = true; //declare to stay in this cell - not to loose the focus!
                    view.Rows[e.RowIndex].ErrorText = "the quantity must be a non-negative decimal"; //error massage
                }
            }
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
            colID.DataPropertyName = "LineID";
            colID.Width = 75;

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
            view.Columns.AddRange(colID, colDescription, colUnit, colCost,colQnty, colExtended);
            view.Dock = DockStyle.None;
            this.Controls.Add(view);
            
            view.DataSource = bsLineItems;
            var t = _ordersService.GetOrderByID(5000).PurchaseLineItem;
         
            foreach (var item in t)
            {
                lineItems.Add(new PurchaseLineItemWrapper(item));
            }

            bsLineItems.DataSource = lineItems;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            listBox1.DisplayMember = "ItemDescription";
            this.listBox1.DataSource = _partService.SearchParts(tb.Text, SearchOptions.Contains);
        }
    }
}
