using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Interfaces;
using DataLayer.Services;
using DataLayer.Entities;


namespace Weaselware.InventoryFerret
{
    public partial class NewOrderForm : Form
    {
        BadgerDataModel _ctx;
        ISuppliersService suppliersService;
        IJobsService jobsService;
        Job _selectedJob = null;
        Supplier _selectedSupplier = null;

        public Job SelectedJob { get => _selectedJob; set => _selectedJob = value; }
        public Supplier SelectedSupplier { get => _selectedSupplier; set => _selectedSupplier = value; }

        public NewOrderForm(BadgerDataModel context)
        {
            InitializeComponent();
            _ctx = context;
            suppliersService = new SuppliersService(_ctx);
            jobsService = new JobsService(_ctx);
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            this.btnNewOrder.Enabled = false;
            
        }

        private void tbSuppliersSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string search = tb.Text;
            var suppliers = suppliersService.Find(search);
            this.lbSuppliersList.DisplayMember = "SupplierName";
            this.lbSuppliersList.DataSource = suppliers;

        }

        private void tbJobSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string search = tb.Text;
            var jobs = jobsService.GetJobs(search);
            this.lbJobSearchList.DisplayMember = "Jobname";
            this.lbJobSearchList.DataSource = jobs;
        }

        private bool OrderReady()
        {
            bool result = false;
            if(_selectedJob != null && _selectedJob != null)
            {
                result = true;
            }
            return result;
        }

        private void lbSuppliersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;

            _selectedSupplier = (Supplier)lb.SelectedItem;
            string supplierResult = _selectedSupplier?.SupplierName ?? "None";
            this.Text = String.Format("Supplier : {0}  ->  Job : {1}", supplierResult, _selectedJob?.Jobname ?? "None");
            this.btnNewOrder.Enabled = OrderReady();
        }

        private void lbJobSearchList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;

           _selectedJob = (Job)lb.SelectedItem;
            this.Text = String.Format("Supplier : {0} -> Job : {1}", _selectedSupplier?.SupplierName ?? "None", _selectedJob?.Jobname ?? "None");
            this.btnNewOrder.Enabled = OrderReady();
        }
    }
}
