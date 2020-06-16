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

namespace Weaselware.InventoryFerret.UserControls
{
    public partial class OrderFeeControl : UserControl
    {

        public event EventHandler OnAddFeeHandler;
        public event EventHandler OnRemoveFeeHandler;
        protected virtual void OnSave(EventArgs e)
        {
            if (OnAddFeeHandler != null)
            { OnAddFeeHandler(this, e); }
        }

        protected virtual void OnPrint(EventArgs e)
        {
            if (OnRemoveFeeHandler != null)
            {
                OnRemoveFeeHandler(this, e);
            }
        }

        public OrderFeeControl()
        {
            InitializeComponent();
        }

        public void SetDataSource(BadgerDataModel context,int orderID)
        {

        }

        private void OrderFeeControl_Load(object sender, EventArgs e)
        {

        }
    }
}
