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
using DataLayer.Models;

namespace Weaselware.InventoryFerret.UserControls
{
    public partial class OrderEditSplitPanelControl : UserControl
    {

        private BindingSource bsOrder;
        private  BadgerDataModel ctx;


        #region Ctors

        public OrderEditSplitPanelControl()
        {
            InitializeComponent();
            InitializeGrid();
        }
        public OrderEditSplitPanelControl(BadgerDataModel context, BindingSource BSorder)
        {
            InitializeComponent();
            ctx = context;
        }

        public void SetDataSource(BadgerDataModel context, BindingSource BSorder)
        {
            ctx = context;
            bsOrder = BSorder;
            // Bind line items to the grid
            BindLineItemsToGrid(bsOrder);
            // int the PartFinder
            this.partFinderControl1
                .LoadDatasource(ctx, ((OrderDetailDto)bsOrder.DataSource).SupplierID);
            this.orderHeaderVerticalControl1.LoadDataSource(bsOrder);
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

        private void BindLineItemsToGrid(BindingSource bsOrder)
        {

        }

       

        private void partFinderControl1_Load(object sender, EventArgs e)
        {
            //partFinderControl1.LoadDatasource()
        }

        private void tsTooglePanels_Click(object sender, EventArgs e)
        {
            scLineItems.Panel2Collapsed  = !scLineItems.Panel2Collapsed;
        }

        private void tsToogleHeader_Click(object sender, EventArgs e)
        {
            splitContainerMain.Panel1Collapsed = !splitContainerMain.Panel1Collapsed;
        }
    }
}
