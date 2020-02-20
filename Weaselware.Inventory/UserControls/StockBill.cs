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

namespace Weaselware.InventoryFerret {

    public partial class StockBill : UserControl {

        BadgerDataModel _context;

        public StockBill(BadgerDataModel ctx) {
            InitializeComponent();
            _context = ctx;
            BarCodeReader reader = new BarCodeReader();

        }

        private void StockBill_Load(object sender, EventArgs e) {

        }

        private void CloseBox_Click(object sender, EventArgs e) {
            TabPage tabpage = (TabPage)this.Parent;
            TabControl tabControl = (TabControl)tabpage.Parent;
            tabControl.TabPages.Remove(tabpage);
        }

        private void btnAddScannedItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
