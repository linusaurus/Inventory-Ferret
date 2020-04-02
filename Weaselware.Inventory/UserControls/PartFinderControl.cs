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

namespace Weaselware.InventoryFerret
{
    public partial class PartFinderControl : UserControl
    {
        BadgerDataModel _ctx;
        IPartsService partsService;
        SearchOptions _searchOptions = SearchOptions.Contains;
        private Part _selectedPart;
        String currentPartSearch;
        BindingSource bsPart = new BindingSource();

        #region Events

        public class PartAddedArgs : System.EventArgs
        {
            public Part selectPart { get; set; }
        }
        public delegate void AddPartHandler(object sender, PartAddedArgs e);
        public event AddPartHandler OnPartAdded;

        #endregion

        public Part SelectedPart { get => _selectedPart; set => _selectedPart = value; }

        public PartFinderControl()
        {
            InitializeComponent();
            _ctx = new BadgerDataModel();
            partsService = new PartsService(_ctx);
            dgvPartsSearchResults.AutoGenerateColumns = false;
        }

        public void SetDataContext(BadgerDataModel context)
        {
            _ctx = context;
            partsService = new PartsService(_ctx);
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

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {

            if (OnPartAdded != null)
            {
                if (OnPartAdded != null)
                {
                    if (_selectedPart != null)
                    {
                        OnPartAdded(this, new PartAddedArgs { selectPart = _selectedPart });
                    }
                    
                }
            }
        }

        private void dgvPartsSearchResults_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.DataSource != null)
            {
                if (dgv.Rows.Count > 0)
                {
                    _selectedPart = (Part)dgv.CurrentRow.DataBoundItem;
                }
            }
            
        }
    }
}
