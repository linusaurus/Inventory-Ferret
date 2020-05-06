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
using System.IO;
using System.Diagnostics;

namespace Weaselware.InventoryFerret.UserControls
{
    public partial class OrderEditControl : UserControl
    {
        private readonly BadgerDataModel _context;
        private readonly IOrdersService _orderService;
        private readonly IPartsService _partService;

        private readonly BindingSource bslineItems = new BindingSource();
        private readonly BindingSource bsOrderHeader = new BindingSource();
        private readonly BindingSource bsOrderFees = new BindingSource();
        private readonly BindingSource bsAttachments = new BindingSource();

        private PurchaseOrder _purchaseOrder;
        private OrderDetailDto orderDTO = new OrderDetailDto();
        private readonly IMapper<PurchaseOrder, OrderDetailDto> mapper = new PurchaseOrderMapper();
        bool _isDirty = false;
        private AttachmentDto _selectedAttachmentDTO = null;


        public OrderEditControl()
        {
            InitializeComponent();
            _context = new BadgerDataModel();
            _orderService = new OrdersService(_context);
            _partService = new PartsService(_context);
            //disable AutoGenerate Columns on grids
            dgOrderLineItem.AutoGenerateColumns = false;
            dgOrderFees.AutoGenerateColumns = false;
            dgAttachments.AutoGenerateColumns = false;
            // Event wiring -------------------------------------------------------------------
            dgOrderLineItem.DataError += DgOrderLineItem_DataError;                       
            dgOrderLineItem.CellValidating += DgOrderLineItem_CellValidating;
            dgOrderLineItem.CellEndEdit += DgOrderLineItem_CellEndEdit;
            dgOrderLineItem.CellValueChanged += DgOrderLineItem_CellValueChanged;
            bslineItems.ListChanged += BslineItems_ListChanged;
            bsOrderFees.ListChanged += BsOrderFees_ListChanged;
            bsAttachments.ListChanged += BsAttachments_ListChanged;
            partFinderControl1.OnJobPartAdded += PartFinderControl1_OnJobPartAdded;
            partFinderControl1.OnPartAdded += PartFinderControl1_OnPartAdded;
            // Event Wiring -------------------------------------------------------------------

            InitializeGrid();
            btnSave.Enabled = _isDirty;
        }

        private void BsAttachments_ListChanged(object sender, ListChangedEventArgs e)
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

        private void BsOrderFees_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == System.ComponentModel.ListChangedType.ItemChanged)
            {
                
                _isDirty = true;
                btnSave.Enabled = _isDirty;
               orderDTO.ShippingCost = orderDTO.OrderFees.ToList().Sum(d => d.Cost * d.Qnty);
            }
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                _isDirty = true;
                btnSave.Enabled = _isDirty;
                orderDTO.ShippingCost = orderDTO.OrderFees.ToList().Sum(d => d.Cost * d.Qnty);

            }
        }

        private void PartFinderControl1_OnPartAdded(object sender, PartFinderControl.PartAddedArgs e)
        {
            bslineItems.Add(new LineItemDto
            {
                Description = e.selectPart.ItemDescription, 
                PurchaseOrderID = _purchaseOrder.OrderNum,
                JobID = _purchaseOrder.JobId.Value,
                PartID = e.selectPart.PartID,
                UiD = e.selectPart.UID.GetValueOrDefault(),
                Price = e.selectPart.Cost.GetValueOrDefault(),
                Quantity = 0.0m
            }); 
        }

      

        private void DgOrderLineItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.   
            dgOrderLineItem.Rows[e.RowIndex].ErrorText = String.Empty;
            // This little ditty sums the row-cleanly
            dgOrderLineItem.Rows[e.RowIndex].Cells[5].Value = (decimal) dgOrderLineItem.Rows[e.RowIndex].Cells[3].Value
                                                            *  (decimal)dgOrderLineItem.Rows[e.RowIndex].Cells[4].Value;
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
        /// <summary>
        /// TODO need to remove the Unit of Purchase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void DgOrderLineItem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ;
        }

    
        public void LoadByID(int id)
        {
           
            if (id != default)
            {
                _purchaseOrder = _orderService.GetOrderByID(id);
                mapper.Map(_purchaseOrder, orderDTO);
                bsOrderHeader.DataSource = orderDTO;
                if (_purchaseOrder != null)
                {
                    bsOrderHeader.DataSource = orderDTO;
                    this.purchaseOrderHeaderControl1.SetDataSource(bsOrderHeader);

                    LoadOrder(id);
                    bsOrderHeader.ListChanged += BsOrderHeader_ListChanged;
                    this.partFinderControl1.LoadDatasource(_context, _purchaseOrder.SupplierId.Value);
                   
                   
                }
            }
        }

        private void PartFinderControl1_OnJobPartAdded(object sender, PartFinderControl.JobPartAddedArgs e)
        {
            bslineItems.Add(new LineItemDto {Description="New Job Item",PurchaseOrderID=_purchaseOrder.OrderNum,JobID=_purchaseOrder.JobId.Value });
        }

        private void BsOrderHeader_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == System.ComponentModel.ListChangedType.ItemChanged)
            {
                _isDirty = true;
                btnSave.Enabled = _isDirty;
            };
        }

        private void LoadOrder(int orderNumber)
        {
            BindingList<LineItemDto> lines = new BindingList<LineItemDto>(orderDTO.LineItems);
            

            bslineItems.DataSource = lines;
            dgOrderLineItem.DataSource = bslineItems;

            bsAttachments.DataSource = orderDTO.Attachments;
            dgAttachments.DataSource = bsAttachments;

            bsOrderFees.DataSource = orderDTO.OrderFees;
            dgOrderFees.DataSource = bsOrderFees;

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
            LoadByID(_purchaseOrder.OrderNum);
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
            //DataGridViewComboBoxColumn colUnit = new DataGridViewComboBoxColumn();
            //colUnit.Width = 60;
            //colUnit.DisplayMember = "UOM";
            //colUnit.ValueMember = "UiD";
            //colUnit.DataPropertyName = "UiD";
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
        #endregion
        //  Close the Tab and Contentss
        private void button1_Click(object sender, EventArgs e)
        {
            TabPage tabpage = (TabPage)this.Parent;
            TabControl tabControl = (TabControl)tabpage.Parent;
            tabControl.TabPages.Remove(tabpage);
        }

   
        /// <summary>
        /// Add an Order Fee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddOrderFee_Click(object sender, EventArgs e)
        {
            if (_purchaseOrder != null && _purchaseOrder.OrderNum != default)
            {               
                OrderFeeDto newOrderFee = new OrderFeeDto
                {
                    Cost = decimal.Zero,
                    FeeName = string.Empty,
                    Qnty = 1.0m,
                    Extension = decimal.Zero

                };
                bsOrderFees.Add(newOrderFee);             
            }
            
        }

        private void btnAddAttachment_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            AttachmentDto newAttachment = new AttachmentDto
            {
                OrderNum = orderDTO.PurchaseOrderID,
                AttachmentDescription = string.Empty,
                Src = string.Empty,
                //FileSource = new byte[],
                Ext = ".pdf",


            };

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                   
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    FileInfo fileInfo = new FileInfo(filePath);
                    newAttachment.Ext = fileInfo.Extension;
                    newAttachment.Src = fileInfo.Name.ToString();
                    newAttachment.FileSize = FileHelpers.GetSizeInMemory(fileInfo.Length);
                    newAttachment.creator = orderDTO.Purchaser;
                    newAttachment.CreatedDate = DateTime.Today;
                    //Read the bytes of the file into a byte array
                    newAttachment.FileSource = File.ReadAllBytes(filePath);
                }
            }
     
            bsAttachments.Add(newAttachment);
        }

        private void dgAttachments_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            DataGridViewRow row = dg.CurrentRow;

            if (bsAttachments.DataSource != null)
            {
                if (dgAttachments.Rows.Count > 0)
                {

                    AttachmentDto selectedAttachment = (AttachmentDto) row.DataBoundItem;
                    if (selectedAttachment != null)
                    {
                        _selectedAttachmentDTO = selectedAttachment;
                    }
                }
            }
        }

        private void btnOpenAttachment_Click(object sender, EventArgs e)
        {
            
            string localPath = String.Format("{0}\\WeaselScat\\", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            if (!File.Exists(localPath))
            {
                System.IO.Directory.CreateDirectory(localPath);
            }
            
            if (_selectedAttachmentDTO != null)
            {
                localPath += _selectedAttachmentDTO.Src;
                System.IO.File.WriteAllBytes(localPath, _selectedAttachmentDTO.FileSource);
                Process.Start(localPath);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedAttachmentDTO != null)
            {
                var filePath = string.Empty;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;
                        FileInfo fileInfo = new FileInfo(filePath);
                        _selectedAttachmentDTO.Ext = fileInfo.Extension;
                        _selectedAttachmentDTO.Src = fileInfo.Name.ToString();
                        _selectedAttachmentDTO.FileSize = FileHelpers.GetSizeInMemory(fileInfo.Length);
                        _selectedAttachmentDTO.creator = orderDTO.Purchaser;
                        _selectedAttachmentDTO.CreatedDate = DateTime.Today;
                        //Read the bytes of the file into a byte array
                        _selectedAttachmentDTO.FileSource = File.ReadAllBytes(filePath);

                    }
                }
            }
        }

        private void partFinderControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnDeleteAttachment_Click(object sender, EventArgs e)
        {
            if (_selectedAttachmentDTO != null)
            {

                bsAttachments.Remove(_selectedAttachmentDTO);
                
            }
        }

       
    }
}
