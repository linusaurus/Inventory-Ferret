﻿using System;
using DataLayer.Entities;
using DataLayer.Services;
using DataLayer.Interfaces;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using Weaselware.InventoryFerret.Wrapper;
using Boxed.Mapping;
using DataLayer.Models;
using System.Linq;
using Weaselware.InventoryFerret.Mappers;


namespace Weaselware.InventoryFerret
{
    public partial class PurchaseOrderControl : UserControl
    {

        //Internals
        PurchaseOrder _po;
        Supplier _supplier = null;
       


        // DATA OBJECTS
        UnitOfMeasure _selectedMeasure;
        IPartsService _partService;
        IOrdersService _ordersService;
        BadgerDataModel _ctx;
        BindingSource bsLineItems;
        BindingSource bsOrderHeader;
        Part _selectedPart = null;
        PurchaseLineItem _selectedPurchaseLineItem = null;
        OrderDetailDto orderHeader = new OrderDetailDto();
        private List<PurchaseLineItemWrapper> lineItems = new List<PurchaseLineItemWrapper>();
        private IEnumerable<SupplierLineItemDto> supplierLineItems;
       
        bool _isDirty = false;
        IMapper<PurchaseOrder, OrderDetailDto> mapper;
        

        // Repos
        SuppliersService _suppliersService;
      


        //This might remain for existing orders opening, not sure
        public PurchaseOrderControl(PurchaseOrder purchaseOrder)
        {
            InitializeComponent();
            _po = purchaseOrder;

        }

        // Hydrate a PO------------------------
        public PurchaseOrderControl(BadgerDataModel context, PurchaseOrder purchaseOrder)
        {
            InitializeComponent();
            _po = purchaseOrder;

            mapper = new Mappers.PurchaseOrderMapper();
            mapper.Map(_po, orderHeader);
           
             _ctx = new BadgerDataModel();
            // Load related children data
            _selectedMeasure = new UnitOfMeasure { UID = 1, Uom = "Each" };
            _suppliersService = new SuppliersService(_ctx);
            _partService = new PartsService(_ctx);
            _ordersService = new OrdersService(_ctx);
            // ----------------------------------
            bsLineItems = new BindingSource();
            bsOrderHeader = new BindingSource();
            _supplier = _suppliersService.Find(_po.SupplierId.Value);
         
            supplierLineItems = _ordersService.GetSupplierLineItems(_supplier.SupplierId);
                
        }

        private void BsLineItems_CurrentItemChanged(object sender, EventArgs e)
        {
            
            if (bsLineItems.Count > 0)
            {
                if (bsLineItems.Current != null)
                {
                   
                }
            }
        }

        private void PurchaseOrderControl_Load(object sender, EventArgs e)
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
            //bsOrderHeader.DataSource = _ordersService.GetOrderDTO(_po.OrderNum);
            //OrderDetailDto header = _ordersService.GetOrderDTO(_po.OrderNum);
            bsOrderHeader.DataSource = orderHeader;
            this.purchaseOrderHeaderControl1.SetDataSource(bsOrderHeader);

            bsOrderHeader.ListChanged += BsOrderHeader_ListChanged;
            btnSave.Enabled = _isDirty;

        }

        private void BsOrderHeader_ListChanged(object sender, ListChangedEventArgs e)
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
                    PartID = part.PartID,
                    UnitCost = part.Cost,
                    VendorId = _supplier.SupplierId,
                    JobId = _po.JobId,
                    Uom = part.UID,
                    Qnty = 1.0m,
                    Extended = 0.0m,
                    AmountReceived = 0.0m,
                    PurchaseOrderId = _po.OrderNum
                };
                _ctx.Entry(newLine).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                var addLine = new PurchaseLineItemWrapper(newLine);
                bsLineItems.Add(addLine);
                _isDirty = true;
                btnSave.Enabled = _isDirty;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (view.DataSource != null)
            {
                if (view.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in view.SelectedRows)
                    {
                        if (row.DataBoundItem != null)
                        {
                            PurchaseLineItem line = ((PurchaseLineItemWrapper)row.DataBoundItem).Model;
                           
                            if (line.LineID != default(int))
                            {
                                _ctx.PurchaseLineItem.Remove(line);

                            }

                            SaveChanges();
                        }

                    }
                    
                   
                }
               
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
            view.Columns.AddRange(colID, colPartID, colDescription, colUnit, colCost, colQnty, colExtended);
            view.Dock = DockStyle.None;
            this.Controls.Add(view);

            BindGrid();

            bsLineItems.DataSource = lineItems;
        }

        private void BindGrid()
        {

            //var t = _ordersService.GetOrderByID(_po.OrderNum).PurchaseLineItem;
            var t = _po.PurchaseLineItem;

            foreach (var item in t)
            {
                lineItems.Add(new PurchaseLineItemWrapper(item));
            }
            bsLineItems.DataSource = lineItems;
            view.DataSource = bsLineItems;
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
              
                _po.OrderTotal = result;
                 mapper.Map(_po, orderHeader);
                purchaseOrderHeaderControl1.SetDataSource(bsOrderHeader);
                partFinderControl1.LoadDatasource(_ctx, _po.SupplierId.Value);
                partFinderControl1.OnJobPartAdded += PartFinderControl1_OnJobPartAdded;
                partFinderControl1.OnPartAdded += PartFinderControl1_OnPartAdded;
                
            }
        }

        private void PartFinderControl1_OnPartAdded(object sender, PartFinderControl.PartAddedArgs e)
        {
            throw new NotImplementedException();
        }

        private void PartFinderControl1_OnJobPartAdded(object sender, PartFinderControl.JobPartAddedArgs e)
        {
            throw new NotImplementedException();
        }

        private void View_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 3)
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

        private void View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int partNumber = int.Parse(view.Rows[e.RowIndex].Cells[1].Value.ToString());
            if (partNumber != 0)
            {
                // Open the part Editor or other action
            }


        }

        private void View_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TotalOrder();
        }

        #endregion


        private void CloseBox_Click(object sender, EventArgs e)
        {
            TabPage tabpage = (TabPage)this.Parent;
            TabControl tabControl = (TabControl)tabpage.Parent;
            tabControl.TabPages.Remove(tabpage);
        }

        private void SaveChanges()
        {
            _ctx.SaveChanges();
            _ordersService.CreateOrUpdateOrder(orderHeader);
            _isDirty = false;
            btnSave.Enabled = false;
            view.Rows.Clear();
            BindGrid();
            bsLineItems.ResetBindings(false);
        }

        #region Search engines

        #endregion

        private void lbPartsResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            if (lb.DataSource != null)
            {
                if (lb.Items.Count > 0)
                {
                    _selectedPart = (Part)lb.SelectedItem;
                }
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (_selectedPart != null)
            {
                PurchaseLineItem newItem = new PurchaseLineItem
                {
                    LineID = 1102,
                    PartID = _selectedPart.PartID,
                    PurchaseOrderId = _po.OrderNum,
                    Qnty = 0.0m,
                    VendorId = _supplier.SupplierId,
                    UnitCost = _selectedPart.Cost.GetValueOrDefault(),
                    Extended = decimal.Zero,
                    Description = _selectedPart.ItemDescription
                };
                PurchaseLineItemWrapper wrap = new PurchaseLineItemWrapper(newItem);
                bsLineItems.Add(wrap);
                bsLineItems.EndEdit();
               
            }
        }

        private void On_JobPartClicked(object sender, EventArgs e)
        {
            PurchaseLineItem newItem = new PurchaseLineItem
            {
                LineID = 1102,
                Qnty = 0.0m,
                PartID = 0,
                UnitCost = 0.0m,
                Extended = decimal.Zero,
                Description = String.Empty
            };
            PurchaseLineItemWrapper wrap = new PurchaseLineItemWrapper(newItem);
            bsLineItems.Add(wrap);
            bsLineItems.EndEdit();
        }

        private void On_SupplierSearchChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

        }

        #region Error Validation



        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void purchaseOrderHeaderControl1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
