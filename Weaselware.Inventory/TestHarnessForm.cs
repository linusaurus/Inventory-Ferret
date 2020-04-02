using DataLayer.Entities;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weaselware.InventoryFerret.UserControls;

namespace Weaselware.InventoryFerret
{
    public partial class TestHarnessForm : Form
    {
        public int LoggedOnUserID { get; set; }
        private readonly BadgerDataModel _ctx;

        public TestHarnessForm()
        {
            InitializeComponent();
            _ctx = new BadgerDataModel();
        }

        private void TestHarnessForm_Load(object sender, EventArgs e)
        {
            //OrderEditControl po = new OrderEditControl();
            PartFinderControl po = new PartFinderControl(_ctx);
            po.Dock = DockStyle.Fill;
            this.Controls.Add(po);
            // Wireup the events --
            po.OnPartAdded += Po_OnPartAdded;
            po.OnJobPartAdded += Po_OnJobPartAdded;
        }

        private void Po_OnJobPartAdded(object sender, PartFinderControl.JobPartAddedArgs e)
        {
            LineItemDto dto = e.jobLineItem;
            this.Text = dto.Description;
        }

       

        private void Po_OnPartAdded(object sender, PartFinderControl.PartAddedArgs e)
        {
            if (e.selectPart != null)
            {
                this.Text = e.selectPart.ItemDescription.ToString();
            }

        }
    }
}
