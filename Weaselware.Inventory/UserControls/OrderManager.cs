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
using System.Runtime.InteropServices.ComTypes;
using DataLayer.Interfaces;
using DataLayer.Services;

namespace Weaselware.InventoryFerret.UserControls
{
    public partial class OrderManager : UserControl
    {
        private readonly BadgerDataModel ctx;
        private IOrdersService ordersService;
        private ISuppliersService supplierService;
        private IJobsService jobsService;
        private Supplier _selectedSupplier;
        
        public OrderManager(BadgerDataModel context)
        {
            InitializeComponent();
            ctx = context;

            ordersService = new OrdersService(ctx);
            supplierService = new SuppliersService(ctx);
            jobsService = new JobsService(ctx);
            dgOrders.AutoGenerateColumns = false;
        }






        /// <summary>
        /// Close the Tab --
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseBox_Click(object sender, EventArgs e)
        {

        }
        // Search for Suppliers
        private void txtSearchSuppliers_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length > 0)
            {
                lbSuppliers.DataSource = supplierService.Find(tb.Text);
                lbSuppliers.DisplayMember = "SupplierName";
                lbSuppliers.ValueMember = "SupplierID";
               
            }

        }

        private void lbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            _selectedSupplier = (Supplier)lb.SelectedItem;

            if (lb.DataSource != null)
            {
                if (lb.Items.Count > 0)
                {
                    if (_selectedSupplier != null)
                    {                       
                        dgOrders.DataSource = ordersService.FindSupplierOrders(_selectedSupplier.SupplierId).ToList(); ;
                    }
                    else
                    {
                        
                    }

                }
            }
        }
        /// <summary>
        /// Search For Job Orders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearchJobs_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length > 0)
            {
                lbJobsList.DataSource = jobsService.GetJobs(tb.Text);
                lbJobsList.DisplayMember = "JobName";
                lbJobsList.ValueMember = "JobID";

            }
        }
    }
}
