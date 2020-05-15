using System;
using System.Data;
using System.Linq;
using DataLayer.Entities;
using DataLayer.Services;
using DataLayer.Interfaces;
using System.Windows.Forms;

namespace Weaselware.InventoryFerret {
    public partial class JobOrdersControl : UserControl {

        BadgerDataModel _context;
        JobsService _jobService;
        LineItemsService _lineService;
        Job currentJob;

        public JobOrdersControl(BadgerDataModel ctx) {
    
            InitializeComponent();
            _context = ctx;
            dgJobOrders.AutoGenerateColumns = false;
            dgJobOrderItems.AutoGenerateColumns = false;
            _jobService = new JobsService(_context);
            _lineService = new LineItemsService(_context);
            // Use last entered search term ---
            txtJobNameSearch.Text = (InventoryFerret.Properties.Settings.Default.LastJobSearch != String.Empty)? 
                Properties.Settings.Default.LastJobSearch : string.Empty;
        }
  
        private void txtJobNameSearch_TextChanged(object sender, EventArgs e) {

            TextBox tb = (TextBox)sender;
            string searchTerm = tb.Text.ToString();
            if (tb.Text.Length > 0){

                lbJobsList.DataSource = _jobService.GetJobs(searchTerm);
                lbJobsList.DisplayMember = "JobName";
                Properties.Settings.Default.LastJobSearch = searchTerm;
                Properties.Settings.Default.Save();
            }
        }

        private void lbJobsList_SelectedIndexChanged(object sender, EventArgs e) {

            ListBox lb = (ListBox)sender;
            if (lb.DataSource != null)
            {
                if (lb.SelectedItems.Count > 0)
                {
                    Job j = (Job) lb.SelectedItem;
                    currentJob = j;
                    dgJobOrders.DataSource = j.PurchaseOrder.OrderByDescending(c=> c.OrderDate).ToList();
                }
            }

        }

        private void dgJobOrders_SelectionChanged(object sender, EventArgs e) {

            if (dgJobOrders.DataSource != null)
            {
                if (dgJobOrders.RowCount > 0)
                {
                  PurchaseOrder p = (PurchaseOrder)dgJobOrders.CurrentRow.DataBoundItem;
                   dgJobOrderItems.DataSource = p.PurchaseLineItem.ToList();
                }
            }
        }

        private void JobOrdersControl_Load(object sender, EventArgs e) {


        }

        private void txtJobItemSearch_TextChanged(object sender, EventArgs e) {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length > 0)
            {
                string searchTerm = tb.Text;

                if (currentJob != null)
                {
                    dgJobOrderItems.DataSource = _lineService.GetJobItems(currentJob.JobId, searchTerm);
                }
            }
        }
    }
}
