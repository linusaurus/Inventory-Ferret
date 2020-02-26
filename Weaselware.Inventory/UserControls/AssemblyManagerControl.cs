using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Services;
using DataLayer.Entities;
using DataLayer.Interfaces;

namespace Weaselware.InventoryFerret.UserControls
{
    public partial class AssemblyManagerControl : UserControl
    {
        // Context Init
        readonly BadgerDataModel _context;
        Job _selectedJob;
        Assembly _selectedAssembly;

        IJobsService jobsService;
        IProductionRepository productionRepository;
        BindingSource bsAssemblies = new BindingSource();
        BindingSource bsSubAssemblies = new BindingSource();
        BindingSource bsStockBillItems = new BindingSource();
        
        public AssemblyManagerControl(BadgerDataModel context)
        {
            InitializeComponent();
            _context = context;
            productionRepository = new ProductionRepository(_context);
            jobsService = new JobsService(_context);
            // testing only
            _selectedJob = jobsService.Find(1172);
        }

        private void AssemblyManagerControl_Load(object sender, EventArgs e)
        {
            bsAssemblies.DataSource = productionRepository.GetJobAssemblies(1172);
            btnSave.Enabled = false;
            this.dgvAssemblies.AutoGenerateColumns = false;
            dgvSubassemblies.AutoGenerateColumns = false;
            dgvStockBillItems.AutoGenerateColumns = false;
            this.dgvAssemblies.DataSource = bsAssemblies;
            this.dgvStockBillItems.DataSource = bsStockBillItems;
            // Event Wire-ups ---------------
            bsAssemblies.AddingNew += BsAssemblies_AddingNew;
            bsAssemblies.CurrentItemChanged += BsAssemblies_CurrentItemChanged;
        }

        private void BsAssemblies_CurrentItemChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            
        }

       
       

        private void BsAssemblies_AddingNew(object sender, AddingNewEventArgs e)
        {
            if (_selectedJob != null)
            {
                Assembly newAssembly = new Assembly { JobID = _selectedJob.JobId, Depth = 0.0m, Height = 0.0m, Width = 0.0m };
                _context.Entry(newAssembly).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                e.NewObject = newAssembly;
                
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {         
            _context.SaveChanges();
        }

        private void dgvAssemblies_SelectionChanged(object sender, EventArgs e)
        {
           DataGridView dv = (DataGridView)sender;
            if (dgvAssemblies.DataSource != null)
            {
                BindingManagerBase bm = BindingContext[dgvAssemblies.DataSource, dgvAssemblies.DataMember];
                if (bm.Count > 0 && bm.Current != null)
                {
                    _selectedAssembly = (Assembly)bm.Current;
                    // bsSubAssemblies.DataSource = productionRepository.GetSubAssemblies(_selectedAssembly.AssemblyId);
                    bsSubAssemblies.DataSource = _selectedAssembly.SubAssembly;
                    this.dgvSubassemblies.DataSource = bsSubAssemblies;
                    BindProductDetails();
                }
            }
        }

        #region Bindings

        private void BindProductDetails()
        {
            if (_selectedAssembly != null)
            {
                bsStockBillItems.DataSource = productionRepository.GetStockBillItems(_selectedAssembly.ProductId);
            }
        }

        #endregion
    }
}
