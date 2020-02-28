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

        }

        private void View_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            TotalOrder();
        }

     

        private void TotalOrder()
        {
            if (bsLineItems.DataSource != null)
            {
                decimal result = decimal.Zero;

                foreach (var item in bsLineItems)
                {
                    result +=((PurchaseLineItemWrapper)item).Extended; 
                   
                        
                    
                }

                this.textBox1.Text = result.ToString("C");
            }
        }


        private void InitializeGrid()
        {
            

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "0.00";
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
    }
}
