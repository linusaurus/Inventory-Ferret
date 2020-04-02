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


        public TestHarnessForm()
        {
            InitializeComponent();
        }

        private void TestHarnessForm_Load(object sender, EventArgs e)
        {
            //OrderEditControl po = new OrderEditControl();
            PartFinderControl po = new PartFinderControl();
            po.Dock = DockStyle.Fill;
            this.Controls.Add(po);
        }
    }
}
