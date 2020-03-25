using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DataLayer.Entities;
using DataLayer.Services;
using DataLayer.Interfaces;
using DataLayer.Models;
using Boxed.Mapping;
using Weaselware.InventoryFerret.Mappers;
using Weaselware.InventoryFerret.Services;

namespace Weaselware.InventoryFerret.UserControls
{
    public partial class OrderEditControl : UserControl
    {
        private readonly BadgerDataModel _context;
        private readonly IOrdersService _orderService;
        private readonly IPartsService _partService;
        private readonly BindingSource bslineItems = new BindingSource();
        private PurchaseOrder _purchaseOrder;
        private OrderDetailDto orderDTO = new OrderDetailDto();
        private readonly IMapper<PurchaseOrder, OrderDetailDto> mapper = new PurchaseOrderMapper();
        bool _isDirty = false;


        public OrderEditControl()
        {
            InitializeComponent();
            _context = new BadgerDataModel();
            _orderService = new OrdersService(_context);
            _partService = new PartsService(_context);
           
            dgOrderLineItem.AutoGenerateColumns = false;
            // Event wiring -------------------------------------------------------------------
            dgOrderLineItem.DataError += DgOrderLineItem_DataError;                       
            dgOrderLineItem.CellValidating += DgOrderLineItem_CellValidating;
            dgOrderLineItem.CellEndEdit += DgOrderLineItem_CellEndEdit;
            dgOrderLineItem.CellValueChanged += DgOrderLineItem_CellValueChanged;
            bslineItems.ListChanged += BslineItems_ListChanged;

            InitializeGrid();
            btnSave.Enabled = _isDirty;
        }

        private void DgOrderLineItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.   
            dgOrderLineItem.Rows[e.RowIndex].ErrorText = String.Empty;

            dgOrderLineItem.Rows[e.RowIndex].Cells[6].Value = (decimal) dgOrderLineItem.Rows[e.RowIndex].Cells[4].Value
                                                            *  (decimal)dgOrderLineItem.Rows[e.RowIndex].Cells[5].Value;
        }

        private void BslineItems_ListChanged(object sender, ListChangedEventArgs e)
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

        private void DgOrderLineItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            orderDTO.Update(); 
        }

        private void DgOrderLineItem_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewRow row = ((DataGridView)sender).CurrentRow;
            decimal qnty = decimal.Zero;

            // Description -----------------------
            if (e.ColumnIndex == 2)
            {
                if (e.FormattedValue.ToString().Length < 10)
                {
                    dgOrderLineItem.Rows[e.RowIndex].ErrorText = "You have enter some reasonable description";
                    e.Cancel = true;
                }


            }
            // Price Column -----------------------
            if (e.ColumnIndex == 4)
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dgOrderLineItem.Rows[e.RowIndex].ErrorText = "Price can not be null";
                    e.Cancel = true;
                }


            }
            if (e.ColumnIndex == 5)
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dgOrderLineItem.Rows[e.RowIndex].ErrorText = "Price can not be null";
                    e.Cancel = true;
                }
                if (!decimal.TryParse(e.FormattedValue.ToString(), out qnty))
                {
                    dgOrderLineItem.Rows[e.RowIndex].ErrorText = "Quantity must be decimal";
                    e.Cancel = true;
                }

            }
        }

        private void DgOrderLineItem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ;
        }

        /// <summary>
        /// Load Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadOrder_Click(object sender, EventArgs e)
        {
            string test = txtLoadOrder.Text;
            int id;
            if (int.TryParse(test,out id))
            {
                _purchaseOrder = _orderService.GetOrderByID(id);
                mapper.Map(_purchaseOrder, orderDTO);
                if (_purchaseOrder != null)
                {
                    this.purchaseOrderHeaderControl1.SetDataSource(orderDTO);
                    LoadOrder(id);
                 
                }
            }
        }


        private void LoadOrder(int orderNumber)
        {
            BindingList<LineItemDto> lines = new BindingList<LineItemDto>(orderDTO.LineItems);
       
            bslineItems.DataSource = lines;
            dgOrderLineItem.DataSource = bslineItems;
            orderDTO.Update();
            bslineItems.AddingNew += BslineItems_AddingNew;
            
        }

        private void OrderEditControl_Load(object sender, EventArgs e)
        {

        }

        private void BslineItems_AddingNew(object sender, AddingNewEventArgs e)
        {
            
            throw new NotImplementedException();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            orderDTO.Update();
            _orderService.CreateOrUpdateOrder(orderDTO);
            _isDirty = false;
            btnSave.Enabled = false;
           // _orderService.Save();
           
        }

        
       

        #region Grid Configuration --
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

            // PartID Column --
            DataGridViewLinkColumn colPartID = new DataGridViewLinkColumn();
            colPartID.HeaderText = "PartID";
            colPartID.DataPropertyName = "PartID";
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
            colUnit.ValueMember = "UiD";
            colUnit.DataPropertyName = "UiD";
            // UnitCost ----------
            DataGridViewTextBoxColumn colCost = new DataGridViewTextBoxColumn();
            colCost.Width = 60;
            colCost.HeaderText = "Price";
            colCost.DataPropertyName = "Price";
            colCost.DefaultCellStyle = dstyleCurrency;

            // Qnty ----------
            DataGridViewTextBoxColumn colQnty = new DataGridViewTextBoxColumn();
            colQnty.Width = 60;
            colQnty.HeaderText = "Qnty";
            colQnty.DataPropertyName = "Quantity";

            colQnty.DefaultCellStyle = dstyleDecimal;
            // Extended ----------
            DataGridViewTextBoxColumn colExtended = new DataGridViewTextBoxColumn();

            colExtended.Width = 60;
            colExtended.HeaderText = "Extended";
            colExtended.DataPropertyName = "Extended";
            colExtended.DefaultCellStyle = dstyleCurrency;

            colUnit.DataSource = _partService.Units();
            dgOrderLineItem.Columns.AddRange(colID, colPartID, colDescription, colUnit, colCost, colQnty, colExtended);
       

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            orderDTO.Update();
        }

        private void purchaseOrderHeaderControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
