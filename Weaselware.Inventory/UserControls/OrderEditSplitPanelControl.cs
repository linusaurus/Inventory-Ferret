﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Entities;
using DataLayer.Models;
using Weaselware.InventoryFerret.Properties;
using DataLayer.Services;
using System.Configuration;

namespace Weaselware.InventoryFerret.UserControls
{
    public partial class OrderEditSplitPanelControl : UserControl
    {

        private BindingSource bsOrder = new BindingSource();
        private BindingSource bsLineitems = new BindingSource();
        private BindingSource bsOrderFees = new BindingSource();
        private BindingSource bsAttachments = new BindingSource();
        private  BadgerDataModel ctx;
        private OrderDetailDto orderDTO = new OrderDetailDto();
        private OrdersService _orderService;
        private PurchaseOrder _purchaseOrder;

        private AttachmentControl attachmentControl;
        private PartFinderControl partFinderControl;
        private OrderFeeControl orderFeeControl;
        private bool isDirty;

        public bool IsDirty
        {
            get { return isDirty; }
            set { isDirty = value; }
        }

        Mappers.PurchaseOrderMapper mapper;
              
        #region Ctors

        public OrderEditSplitPanelControl()
        {
            InitializeComponent();
            InitializeGrid();
            this.orderHeaderVerticalControl1.OnSaveHandler += OrderHeaderVerticalControl1_OnSaveHandler;
            this.orderHeaderVerticalControl1.OnPrintHandler += OrderHeaderVerticalControl1_OnPrintHandler;
            mapper = new Mappers.PurchaseOrderMapper();
          
           // LoadOrderPanelControl(partFinderControl);   
        }

        public OrderEditSplitPanelControl(BadgerDataModel context, BindingSource BSorder)
        {
            InitializeComponent();
            ctx = context;
            orderDTO =(OrderDetailDto) BSorder.DataSource;
            this.orderHeaderVerticalControl1.OnSaveHandler += OrderHeaderVerticalControl1_OnSaveHandler;
            this.orderHeaderVerticalControl1.OnPrintHandler += OrderHeaderVerticalControl1_OnPrintHandler;
            
        }

        private void OrderHeaderVerticalControl1_OnSaveHandler(object sender, EventArgs e)
        {
            _orderService.CreateOrUpdateOrder(orderDTO);
            LoadOrder();
            isDirty = false;
            ToogleButtonStyle(isDirty);
  
        }

        private void ToogleButtonStyle(bool dirtyState)
        {
            if(dirtyState == true)
            {
                orderHeaderVerticalControl1.btnSave.BackColor = System.Drawing.Color.Cornsilk;
                orderHeaderVerticalControl1.btnSave.FlatStyle = FlatStyle.Flat;
                orderHeaderVerticalControl1.btnSave.FlatAppearance.BorderColor = Color.Red;
                orderHeaderVerticalControl1.btnSave.FlatAppearance.BorderSize = 3;
            }
            else if (dirtyState ==false)
            {
                orderHeaderVerticalControl1.btnSave.BackColor = Color.Gainsboro;
                orderHeaderVerticalControl1.btnSave.FlatAppearance.BorderColor = Color.Cornsilk;
            }
        }
      
        private void OrderHeaderVerticalControl1_OnPrintHandler(object sender, EventArgs e)
        {
            if (orderDTO != null || orderDTO.PurchaseOrderID != default)
            {
                POdataset ds = new POdataset();
 
                POdatasetTableAdapters.PurchaseOrder1TableAdapter adapter = new POdatasetTableAdapters.PurchaseOrder1TableAdapter();
                POdatasetTableAdapters.EmployeeTableAdapter empAdapter = new POdatasetTableAdapters.EmployeeTableAdapter();
                POdatasetTableAdapters.PurchaseLineItemTableAdapter lineAdaper = new POdatasetTableAdapters.PurchaseLineItemTableAdapter();
                POdatasetTableAdapters.OrderFeeTableAdapter feeAdapers = new POdatasetTableAdapters.OrderFeeTableAdapter();
                POdatasetTableAdapters.SupplierTableAdapter supplierAdapter = new POdatasetTableAdapters.SupplierTableAdapter();
                // Hydrate all the internal tables 
                adapter.Fill(ds.PurchaseOrder1, orderDTO.PurchaseOrderID);
                empAdapter.Fill(ds.Employee, orderDTO.EmployeeID);
                lineAdaper.Fill(ds.PurchaseLineItem, orderDTO.PurchaseOrderID);
                feeAdapers.Fill(ds.OrderFee, orderDTO.PurchaseOrderID);
                supplierAdapter.Fill(ds.Supplier, orderDTO.SupplierID);
                
                PrintOrderForm orderFrom = new PrintOrderForm(ds);
                // Show the form with report for printing
                orderFrom.Show();

            }
        }
        
        private bool LoadOrder()
        {
            bool result= false;
            if (orderDTO != null )
            {
                _purchaseOrder = _orderService.GetOrderByID(orderDTO.PurchaseOrderID);
                mapper.Map(_purchaseOrder, orderDTO);
                bsOrder.DataSource = orderDTO;
                bsLineitems.DataSource = orderDTO.LineItems;

                bsAttachments.DataSource = orderDTO.Attachments;
                if (attachmentControl != null){ attachmentControl.SetDatasource(orderDTO, bsAttachments); }
                
                bsOrderFees.DataSource = orderDTO.OrderFees;
                if (orderFeeControl != null) { orderFeeControl.SetDataSource(orderDTO, bsOrderFees); }

                BindLineItemsToGrid(bsLineitems);
            }

            return result;
        }
        // Main preferred control datasource --
        public void SetDataSource(BadgerDataModel context, int orderID)
        {
            // reference the context object
            ctx = context;
            // create a new DTO to hold the order
            orderDTO = new OrderDetailDto();
            _orderService = new OrdersService(ctx);
            // Init the mapper
           
            // Retrieve to PurchaseOrder Entity
            _purchaseOrder = _orderService.GetOrderByID(orderID);

            if (_purchaseOrder != null)
            {
                // Map to the DTO detached data transfer object
                mapper.Map(_purchaseOrder, orderDTO);
                // wire a BindingSource for the order binding
                bsOrder.DataSource = orderDTO;
                // Bind line items to the grid
                bsLineitems.DataSource = orderDTO.LineItems;
                BindLineItemsToGrid(bsLineitems);
                bsOrderFees.DataSource = orderDTO.OrderFees;
                bsAttachments.DataSource = orderDTO.Attachments;
            }

            // Event wiring -------------------------------------------------------------------  
            
            // dgOrderLineItem.DataError += DgOrderLineItem_DataError;
            dgOrderLineItem.CellValidating += DgOrderLineItem_CellValidating;
            dgOrderLineItem.CellEndEdit += DgOrderLineItem_CellEndEdit;
            dgOrderLineItem.CellValueChanged += DgOrderLineItem_CellValueChanged;
            bsLineitems.ListChanged += BslineItems_ListChanged;
           

            bsOrder.ListChanged += BsOrder_ListChanged;
            bsOrderFees.ListChanged += BsOrderFees_ListChanged; ;
            bsAttachments.ListChanged += BsAttachments_ListChanged;  
            
            // Event Wiring -------------------------------------------------------------------

            // start with the PartFinder
           //    partFinderControl
           //         .LoadDatasource(ctx, orderDTO.SupplierID);
                  orderHeaderVerticalControl1.LoadDataSource(bsOrder);

        }
      
        public void SaveChanges()
        {
            _orderService.CreateOrUpdateOrder(orderDTO);      
            isDirty = false;
        }

        private void BsAttachments_ListChanged(object sender, ListChangedEventArgs e)
        {
            CheckForDirtyState(e);
        }

        private void BsOrderFees_ListChanged(object sender, ListChangedEventArgs e)
        {CheckForDirtyState(e);  }

        private void BsOrder_ListChanged(object sender, ListChangedEventArgs e)
        {  CheckForDirtyState(e); }
        private void BslineItems_ListChanged(object sender, ListChangedEventArgs e)
        {CheckForDirtyState(e);  }

        private void CheckForDirtyState(ListChangedEventArgs e)
        {
            if (e.ListChangedType == System.ComponentModel.ListChangedType.ItemChanged)
            {   orderHeaderVerticalControl1.btnSave.Enabled = true;                 
                isDirty = true;
                ToogleButtonStyle(isDirty);
            }
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            { orderHeaderVerticalControl1.btnSave.Enabled = true;
                isDirty = true;
                ToogleButtonStyle(isDirty);
            }
            if (e.ListChangedType == ListChangedType.ItemAdded)
            { orderHeaderVerticalControl1.btnSave.Enabled = true;
                isDirty = true;
                ToogleButtonStyle(isDirty);
            }
        }

        private void DgOrderLineItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            orderDTO.Update();
        }

        private void InitializeGrid()
        {
            dgOrderLineItem.AutoGenerateColumns = false;
            dgOrderLineItem.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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
            colDescription.DefaultCellStyle = dstyleWrapText;
            colDescription.HeaderText = "Description";
            colDescription.DataPropertyName = "Description";
            
            colDescription.Width = 450;
            colDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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

            //colUnit.DataSource = _partService.Units();
            dgOrderLineItem.Columns.AddRange(colID, colPartID, colDescription, colCost, colQnty, colExtended);


        }

        private void DgOrderLineItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.   
            dgOrderLineItem.Rows[e.RowIndex].ErrorText = String.Empty;
            // This little ditty sums the row-cleanly
            dgOrderLineItem.Rows[e.RowIndex].Cells[5].Value = (decimal)dgOrderLineItem.Rows[e.RowIndex].Cells[3].Value
                                                            * (decimal)dgOrderLineItem.Rows[e.RowIndex].Cells[4].Value;
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
            if (e.ColumnIndex == 3)
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dgOrderLineItem.Rows[e.RowIndex].ErrorText = "Price can not be null";
                    e.Cancel = true;
                }
            }
            if (e.ColumnIndex == 4)
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

        #endregion

        private void BindLineItemsToGrid(BindingSource bsOrder)
        {dgOrderLineItem.DataSource = bsOrder;}
            
        

        private void tsTooglePanels_Click(object sender, EventArgs e)
        {
            scLineItems.Panel2Collapsed  = !scLineItems.Panel2Collapsed;
            if (!scLineItems.Panel2Collapsed)
            { tsTooglePanels.Image = Resources.round_keyboard_arrow_up_black_24dp; }
            // ----------------------------------------------------------------------------
            if (scLineItems.Panel2Collapsed)
            {  tsTooglePanels.Image = Resources.round_keyboard_arrow_down_black_24dp;}

        }

        private void tsToogleHeader_Click(object sender, EventArgs e)
        {
            splitContainerMain.Panel1Collapsed = !splitContainerMain.Panel1Collapsed;
        }

        private void tsbToggleAttachment_Click(object sender, EventArgs e)
        {
            attachmentControl = new AttachmentControl();
            attachmentControl.SetDatasource(orderDTO, bsAttachments);           
            LoadOrderPanelControl(attachmentControl);
        }

        private void tsbLoadPartFinder_Click(object sender, EventArgs e)
        {
            partFinderControl = new PartFinderControl();
            partFinderControl.LoadDatasource(ctx, orderDTO.SupplierID);

            partFinderControl.OnJobPartAdded += PartFinderControl_OnJobPartAdded1;
            partFinderControl.OnPartAdded += PartFinderControl_OnPartAdded1;
            LoadOrderPanelControl(partFinderControl);         
        }

        private void tsbToogleOrderFee_Click(object sender, EventArgs e)
        {
            orderFeeControl = new OrderFeeControl();
            orderFeeControl.SetDataSource(orderDTO, bsOrderFees);
            LoadOrderPanelControl(orderFeeControl);
        }

        private void PartFinderControl_OnPartAdded1(object sender, PartFinderControl.PartAddedArgs e)
        {
            if (e.selectPart != null)
            {
                LineItemDto newLineItem = new LineItemDto
                {
                    PurchaseOrderID = orderDTO.PurchaseOrderID,
                    Description = e.selectPart.ItemDescription,
                    JobID = orderDTO.JobID,
                    Quantity = 1.0m,
                    PartID = e.selectPart.PartID,
                    Price = e.selectPart.Cost.GetValueOrDefault(),
                    UiD = e.selectPart.UID.GetValueOrDefault()                  
                };

                bsLineitems.Add(newLineItem);
                
            }
        }

        private void PartFinderControl_OnJobPartAdded1(object sender, PartFinderControl.JobPartAddedArgs e)
        {          
                LineItemDto newLineItem = new LineItemDto
                {
                    PurchaseOrderID = orderDTO.PurchaseOrderID,
                    Description = "new job part...",
                    JobID = orderDTO.JobID,
                    Quantity = 1.0m,
                    PartID = 0,
                    Price = decimal.Zero,
                    UiD = 1
                };

                bsLineitems.Add(newLineItem);         
        }

       

        private void LoadOrderPanelControl(UserControl control)
        {
            if (control is PartFinderControl)
            {
                if (!scLineItems.Panel2.Controls.Contains(control))
                {
                    scLineItems.Panel2.Controls.Remove(attachmentControl);
                    scLineItems.Panel2.Controls.Remove(orderFeeControl);              
                    control.Dock = DockStyle.Fill;
                    scLineItems.Panel2.Controls.Add(control);
                }
            }
            else if (control is AttachmentControl)
            {
                if (!scLineItems.Panel2.Controls.Contains(control))
                {                  
                    scLineItems.Panel2.Controls.Remove(partFinderControl);              
                    scLineItems.Panel2.Controls.Remove(orderFeeControl);
                    attachmentControl.SetDatasource(orderDTO, bsAttachments);
                    attachmentControl.Dock = DockStyle.Fill;
                    scLineItems.Panel2.Controls.Add(attachmentControl);
                }
            }
            else if (control is OrderFeeControl)
            {
                if (!scLineItems.Panel2.Controls.Contains(control))
                {
                    
                    scLineItems.Panel2.Controls.Remove(partFinderControl);
                    scLineItems.Panel2.Controls.Remove(attachmentControl);
                    control.Dock = DockStyle.Fill;
                    scLineItems.Panel2.Controls.Add(control);
                }
            }

        }


    }
}
