using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DataLayer.Entities;
using DataLayer.Services;

namespace Weaselware.InventoryFerret.UserControls
{
    public partial class PartTypePicker : UserControl
    {
        private BadgerDataModel ctx;
        PartsService _partService;

        public PartTypePicker()
        {
            InitializeComponent();
        }

        public void SetContext(BadgerDataModel context)
        {
            ctx = context;
            _partService = new PartsService(ctx);
        }

        private void PartTypePicker_Load(object sender, EventArgs e)
        {

        }
    }
}
