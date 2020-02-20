using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using DataLayer.Services;
using DataLayer.Interfaces;
using DataLayer.Entities;
using DataLayer.Models;

namespace Weaselware.InventoryFerret
{
    public partial class ClaimDetailControl : UserControl
    {

        private BadgerDataModel _ctx;
      
        private List<SupplierOrderDTO> supplierOrders;
        private BindingList<SupplierOrderDTO> supOrders;
        private List<Supplier> suppliers;
        SuppliersService supService;
        OrdersService ordersService;
        IClaimService claimService;
        int selectedOrder;
        BindingSource bsLineItems = new BindingSource();
        Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);


        public ClaimDetailControl(BadgerDataModel context)
        {
            InitializeComponent();
            _ctx = context;
            supService = new SuppliersService(_ctx);
            ordersService = new OrdersService(_ctx);
            claimService = new ClaimService(_ctx);
            dgSupplierOrders.AutoGenerateColumns = false;
            bsLineItems.DataSource = supplierOrders;
            dgSupplierOrders.DataSource = bsLineItems;
            dgSupplierClaims.AutoGenerateColumns = false;
            tbSupplierSearch.Text = Properties.Settings.Default.LastSupplierSearch;
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            TabPage tabpage = (TabPage)this.Parent;
            TabControl tabControl = (TabControl)tabpage.Parent;
            tabControl.TabPages.Remove(tabpage);
        }

        private void ClaimDetailControl_Load(object sender, EventArgs e)
        {

        }

        private void tbSupplierSearch_TextChanged(object sender, EventArgs e)
        {
            string search = ((TextBox)sender).Text;
            Properties.Settings.Default.LastSupplierSearch = search;
            Properties.Settings.Default.Save();
            suppliers = supService.Find(search);
            this.lbOrdersList.DataSource = suppliers;
        }
        /// <summary>
        /// OrderListbox Select Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbOrdersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;

            if (lbOrdersList.DataSource != null)
            {
                var selectedSupplier = lb.SelectedItem;
                int key = ((Supplier)selectedSupplier).SupplierId;
                bsLineItems.DataSource = ordersService.GetSupplierOrdersDTO(key);
                this.dgSupplierClaims.DataSource = claimService.SupplierClaims(((Supplier)selectedSupplier).SupplierId);
              
                
            }
        }
        /// <summary>
        /// Start Claim on Selected Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btbStartClaim_Click(object sender, EventArgs e)
        {
            if (selectedOrder > 0 )
            {

                var c = claimService.NewClaim(selectedOrder, 8);
                TabPage tab = new TabPage();
                tab.Text = "Claim # " + c.ClaimId.ToString();
                ClaimControl control = new ClaimControl(c.ClaimId, _ctx);
                control.Dock = DockStyle.Fill;
                tab.Controls.Add(control);

                tabClaims.TabPages.Add(tab);
                dgSupplierClaims.DataSource = ordersService.GetSupplierOrders(c.SupplierId.Value);
            }

        }

        private void dgSupplierOrders_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            SupplierOrderDTO selection = (SupplierOrderDTO)dg.CurrentRow.DataBoundItem;
            selectedOrder = selection.OrderNum.Value;
            this.dgSupplierClaims.DataSource = claimService.SupplierClaims(2280);

        }

        private void dgSupplierClaims_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            Claim _claim = (Claim)dg.CurrentRow.DataBoundItem;
            OpenClaimTab(_claim.ClaimId);
        }

        private void OpenClaimTab(int claimID)
        {
            try
            {
                
                TabPage tab = new TabPage();
                tab.Text = "Claim # " + claimID.ToString();
                ClaimControl control = new ClaimControl(claimID, _ctx);
                control.Dock = DockStyle.Fill;
                tab.Controls.Add(control);

                tabClaims.TabPages.Add(tab);
                tabClaims.SelectedTab = tab;
            }
            catch (Exception)
            {

                ;
            }


           
        }
    }
}
