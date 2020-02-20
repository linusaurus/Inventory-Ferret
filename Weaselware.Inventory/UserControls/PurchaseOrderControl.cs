using System;
using DataLayer.Entities;
using DataLayer.Services;
using DataLayer.Interfaces;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using Weaselware.InventoryFerret.Wrapper;

namespace Weaselware.InventoryFerret
{
    public partial class PurchaseOrderControl : UserControl
    {
        // DATA OBJECTS
        private PurchaseOrder _po;

        private List<PurchaseLineItemWrapper> items;
        private BindingSource bsLineItems = new BindingSource();

        private BadgerDataModel _ctx;
       

        // Repos
        SuppliersService suppliersService;
        IOrdersService orderService;
        IPartsService partsService;
        IJobsService jobsService;
        InventoryService inventoryService;


        Part _selectedPart = null;
        

        public PurchaseOrderControl(PurchaseOrder purchaseOrder)
        {
            InitializeComponent();
            _po = purchaseOrder;
            items = new List<PurchaseLineItemWrapper>();
    
            dgLineItems.AutoGenerateColumns = false;
            bsLineItems.DataSource = items;
            dgLineItems.DataSource = bsLineItems;
            _ctx = new BadgerDataModel();
            // Init the repos old school
            suppliersService = new SuppliersService(_ctx);
            orderService = new OrdersService(_ctx);
            partsService = new PartsService(_ctx);
            jobsService = new JobsService(_ctx);

        }

        public PurchaseOrderControl(BadgerDataModel context)
        {
            InitializeComponent();
            _ctx = context;

            items = new List<PurchaseLineItemWrapper>();

            dgLineItems.AutoGenerateColumns = false;
            bsLineItems.DataSource = items;
            dgLineItems.DataSource = bsLineItems;
            bsLineItems.CurrentItemChanged += BsLineItems_CurrentItemChanged;
            

            suppliersService = new SuppliersService(_ctx);
            orderService = new OrdersService(_ctx);
            partsService = new PartsService(_ctx);
            inventoryService = new InventoryService(_ctx);

            dgSupplierParts.DataSource = orderService.GetSupplierLineItems(1404);
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


        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            TabPage tabpage = (TabPage)this.Parent;
            TabControl tabControl = (TabControl)tabpage.Parent;
            tabControl.TabPages.Remove(tabpage);
        }

        private void lblJobName_Click(object sender, EventArgs e)
        {

        }

        private void tbPartsSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string search = tb.Text;
            //partsService = new PartsService(_ctx);
            var parts = partsService.SearchParts(search, SearchOptions.Contains);
            this.lbPartsResults.DisplayMember = "ItemDescription";
            this.lbPartsResults.DataSource = parts;

        }
        /// <summary>
        /// Jobs Search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbJobSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string search = tb.Text;
            jobsService = new JobsService(_ctx);
            var jobs = jobsService.GetJobs(search);
           // this.lbJobSearchList.DisplayMember = "JobName";
           // this.lbJobSearchList.DataSource = jobs;

        }

        #region Search engines

        private void tbSuppliersSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string search = tb.Text;
            var suppliers = suppliersService.Find(search);
           // this.lbSuppliersList.DisplayMember = "SupplierName";
           // this.lbSuppliersList.DataSource = suppliers;
        }


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
                    LineId = 1102,
                    PartId = _selectedPart.PartId,
                    Qnty = 0.0m,
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
                LineId = 1102,
                Qnty = 0.0m,
                PartId = 0,
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

       
    }
}
