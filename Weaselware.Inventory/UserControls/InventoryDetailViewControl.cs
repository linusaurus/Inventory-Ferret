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

namespace Weaselware.InventoryFerret {
    public partial class InventoryDetailViewControl : UserControl {

        Inventory _inventoryItem = new Inventory();

        public InventoryDetailViewControl() {
            InitializeComponent();
        }

        private void InventoryDetailViewControl_Load(object sender, EventArgs e) {


        }

        public void SetDataSource(Inventory inventory) {

            _inventoryItem = inventory;
            if (inventory != null)
            {
                BindData(_inventoryItem);
            }
          
        }

        private void BindData(Inventory inventory) {

            

            this.txtDescription.DataBindings.Clear();
            Invoke(new MethodInvoker(() => { this.txtDescription.DataBindings.Add("Text", _inventoryItem, "Description"); }));

            this.txtSupplierName.DataBindings.Clear();
            Invoke(new MethodInvoker(() => { this.txtSupplierName.DataBindings.Add("Text", _inventoryItem, "SupplierName"); }));

            txtInventoryTag.DataBindings.Clear();
            Invoke(new MethodInvoker(() => { txtInventoryTag.DataBindings.Add("Text", _inventoryItem, "StockTransactionID"); }));

            txtOrderDate.DataBindings.Clear();
            Invoke(new MethodInvoker(() => { txtOrderDate.DataBindings.Add("Text", _inventoryItem, "OrderReciept.OrderNum"); }));

            txtJobName.DataBindings.Clear();
           // Invoke(new MethodInvoker(() => { txtJobName.DataBindings.Add("Text", _inventoryItem, "Job.JobName"); }));

            txtInventoryTag.DataBindings.Clear();
            Invoke(new MethodInvoker(() => { txtInventoryTag.DataBindings.Add("Text", _inventoryItem, "StockTransactionID"); }));
        }

    }
    }
