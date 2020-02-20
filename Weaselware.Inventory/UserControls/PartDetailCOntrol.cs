using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;
using System.Windows.Forms;

namespace Weaselware.InventoryFerret.UserControls
{
    public partial class PartDetailCOntrol : UserControl
    {

        BindingSource bsPart = new BindingSource();

        public PartDetailCOntrol()
        {
            InitializeComponent();
        }

        private void PartDetailCOntrol_Load(object sender, EventArgs e)
        {

        }

        public void LoadBindings(Part part)
        {
            if (part == null)
            {
                return;
            }

            bsPart.DataSource = part;


            txtPartID.DataBindings.Clear();
            txtPartNum.DataBindings.Clear();
            txtitemDescription.DataBindings.Clear();
            txtItemName.DataBindings.Clear();
            txtLocation.DataBindings.Clear();
            txtSKU.DataBindings.Clear();
            ckbCARB.DataBindings.Clear();

            txtPartID.DataBindings.Add("Text",bsPart,"PartID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtPartNum.DataBindings.Add("Text", bsPart, "PartNum", true, DataSourceUpdateMode.OnPropertyChanged);
            txtitemDescription.DataBindings.Add("Text", bsPart, "ItemDescription", true, DataSourceUpdateMode.OnPropertyChanged);
            txtItemName.DataBindings.Add("Text", bsPart, "ItemName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLocation.DataBindings.Add("Text",bsPart,"Location",true,DataSourceUpdateMode.OnPropertyChanged);
            txtSKU.DataBindings.Add("Text", bsPart, "SKU", true, DataSourceUpdateMode.OnPropertyChanged);
            ckbCARB.DataBindings.Add("Text", bsPart, "CARBtrack", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSKU_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPullStock_Click(object sender, EventArgs e)
        {

        }
    }
}
