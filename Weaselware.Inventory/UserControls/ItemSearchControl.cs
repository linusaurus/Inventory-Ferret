using System;
using System.Collections.Generic;
using System.ComponentModel;
using DataLayer.Entities;
using DataLayer.Services;
using DataLayer.Interfaces;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Weaselware.InventoryFerret {
    public partial class ItemSearchControl : UserControl {

        BadgerDataModel _context;
        BarCodeReader reader = new BarCodeReader();

        public ItemSearchControl(BadgerDataModel ctx) {

            InitializeComponent();
            _context = ctx;
        }

        private void OrderReceiptSearchControl_Load(object sender, EventArgs e) {


        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                btnScanToFind.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnScanToFind_Click(object sender, EventArgs e) {
            
            
            reader.OpenScanner();
            reader.OnBarCodeRead += Reader_OnBarCodeRead;
        }

        private void Reader_OnBarCodeRead(object sender, BarCodeReader.BarCodeReadEventArgs e) {

            
            IPartsService partService = new PartsService(_context);          
            string foundBarCode = e.ValueRead.ToString();
   
            if (foundBarCode != string.Empty )
            {

                int key = int.Parse(foundBarCode);
                var inv = partService.Find(key);
 
                    if (inv != null)
                    {                      
                        Invoke(new MethodInvoker(() => { this.propertyGrid1.SelectedObject = inv; }));
                        Invoke(new MethodInvoker(() => { this.label1.Text = foundBarCode + " : Found"; }));
                    }
                    else
                    {
                        Invoke(new MethodInvoker(() => { this.propertyGrid1.SelectedObject = null; }));
                        Invoke(new MethodInvoker(() => { this.label1.Text = foundBarCode + " : No Match Found"; }));
                    }
            

            }
                        
        }

        private void bntStopScan_Click(object sender, EventArgs e) {
            reader.CloseScanner();
            reader.OnBarCodeRead -= Reader_OnBarCodeRead;
        }

        private void CloseBox_Click(object sender, EventArgs e) {
            TabPage tabpage = (TabPage)this.Parent;
            TabControl tabControl = (TabControl)tabpage.Parent;
            tabControl.TabPages.Remove(tabpage);
        }
    }
}
