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
using DataLayer.Interfaces;
using DataLayer.Services;
using DataLayer.Models;

namespace Weaselware.InventoryFerret
{
    public partial class PartFinderControl : UserControl
    {
        private  BadgerDataModel _ctx;
        IPartsService partsService;
        IOrdersService _ordersService;
        SearchOptions _searchOptions = SearchOptions.Contains;
        private Part _selectedPart;
        String currentPartSearch;
        BindingSource bsPart = new BindingSource();
        private  List<SupplierLineItemDto> 
            supplierLineItems = new List<SupplierLineItemDto>();
        
        #region Events

        // Standard Part --------------
        public class PartAddedArgs : System.EventArgs
        {
            public Part selectPart { get; set; }
        }
        public delegate void AddPartHandler(object sender, PartAddedArgs e);
        public event AddPartHandler OnPartAdded;


        // JobPart  ----------------------------
        public class JobPartAddedArgs : System.EventArgs
        {
            public LineItemDto jobLineItem { get; set; }
        }
        public delegate void AddJobPartHandler(object sender, JobPartAddedArgs e);
        public event AddJobPartHandler OnJobPartAdded;


        // Supplier-Part  ----------------------------
        public class SupplierPartAddedArgs : System.EventArgs
        {
            public LineItemDto jobLineItem { get; set; }
        }
        public delegate void SupplierPartHandler(object sender, JobPartAddedArgs e);
        public event AddJobPartHandler OnSupplierPartAdded;


        #endregion

        public Part SelectedPart { get => _selectedPart; set => _selectedPart = value; }

        public PartFinderControl()
        {
            InitializeComponent();

            
           
        }

      

        public void LoadDatasource(BadgerDataModel context, int supplierID)
        {
            _ctx = context;
            partsService = new PartsService(_ctx);
            _ordersService = new OrdersService(_ctx);
            dgvPartsSearchResults.AutoGenerateColumns = false;
            dgSupplierParts.AutoGenerateColumns = false;
            //This init the EF query-strangly its needed 
            Part blow = partsService.Find(1);
            supplierLineItems = _ordersService.GetSupplierLineItems(supplierID);
            dgSupplierParts.DataSource = supplierLineItems;
            dgSupplierParts.CellContentClick += DgSupplierParts_CellContentClick;
        }

        public PartFinderControl(BadgerDataModel context,int supplierID)
        {
            InitializeComponent();         
        }

        private void DgSupplierParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {               
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {
                SupplierLineItemDto _selectedSupplierLineItem = (SupplierLineItemDto)dg.CurrentRow.DataBoundItem;
                if (_selectedSupplierLineItem != null)
                {
                    var order = _ordersService.GetOrderByID(_selectedSupplierLineItem.OrderNum);
                    //--Open a Purchase Order Page for the order---
                    Mediator.GetInstance().OnOrderOpened(this, order);
                }


            }
               
 
        }

        private void PartFinderControl_Load(object sender, EventArgs e)
        {

        }

        private void tbSearchParts_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length > 0)
            {
                currentPartSearch = tb.Text;
                SearchParts(currentPartSearch);
            }
        }

        private void SearchParts(string search)
        {
            var parts = partsService.SearchParts(search, _searchOptions);
            this.dgvPartsSearchResults.DataSource = parts;
        }
        #region Search Options

        private void rbStartsWith_CheckedChanged(object sender, EventArgs e)
        {
            _searchOptions = SearchOptions.StartsWith;
            SearchParts(currentPartSearch);
        }

        private void rbContains_CheckedChanged(object sender, EventArgs e)
        {
            _searchOptions = SearchOptions.Contains;
            SearchParts(currentPartSearch);
        }

        #endregion

        private void tbSearchParts_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
        }

        private void dgvPartsSearchResults_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.DataSource != null)
            {
                if (dgv.Rows.Count > 0)
                {_selectedPart = (Part)dgv.CurrentRow.DataBoundItem; } 
            }           
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (OnPartAdded != null)
            {
                if (OnPartAdded != null)
                {     if (_selectedPart != null)
                    {OnPartAdded(this, new PartAddedArgs { selectPart = _selectedPart }); }             
                }
            }
        }

        private void btnAddJobPart_Click(object sender, EventArgs e)
        {
            if (OnJobPartAdded != null)
            {
                if (OnJobPartAdded != null)
                { OnJobPartAdded(this, new JobPartAddedArgs { jobLineItem = new LineItemDto { Description = "JobPart" } }); }
            }
        }

        private void btnNewPart_Click(object sender, EventArgs e)
        {
            if (OnJobPartAdded != null)
            {
                if (OnJobPartAdded != null)
                { OnJobPartAdded(this, new JobPartAddedArgs { jobLineItem = new LineItemDto { Description = "JobPart" } }); }
            }
        }
    }
}
