using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Neodynamic.SDK.Printing;
using DataLayer.Entities;

namespace Weaselware.InventoryFerret {
    public partial class PitemsGrid : UserControl
    {


        PurchaseOrder _purchaseOrder;
        BadgerDataModel _ctx;
        BindingSource bsItems = new BindingSource();
        LabelService lbService;

        //public delegate void ChangedEventHandler(object sender, EventArgs e);
        //public event ChangedEventHandler OnPrintLabels;
     

	    public PurchaseOrder Order
	    {
		    get { return _purchaseOrder;}
		    set { _purchaseOrder = value;}
	    }

        
        
	    //  this is a pretty good way to encapsolate the data function 
        //  and pass the context around
        public void SetDataSource(int order,BadgerDataModel ctx)
        {
            _ctx = ctx;
            _purchaseOrder = (from c in _ctx.PurchaseOrder 
                              where c.OrderNum == order select c).FirstOrDefault();

            _purchaseOrder.RecievedDate = DateTime.Today;
            string empName = _purchaseOrder.Employee.Firstname + " " + _purchaseOrder.Employee.Lastname;
            bsItems.DataSource = _purchaseOrder.PurchaseLineItem.ToList();
            this.dgLineItems.DataSource = bsItems;
            // Dependency needs to be injected --
            lbService = new LabelService();
        }
        
        
        public PitemsGrid()
        {
            InitializeComponent();
            this.dgLineItems.AutoGenerateColumns = false;
        }

        private void PitemsGrid_Load(object sender, EventArgs e)
        {}
            
        

        
        // Heres the meat and Potatoes!!
        private void btnReceive_Click(object sender, EventArgs e)
        {
            if (_purchaseOrder != null)
            {
                Processing.RecieveOrder(_purchaseOrder, _ctx);
                TabPage tabpage = (TabPage)this.Parent;
                TabControl tabControl = (TabControl)tabpage.Parent;
                tabControl.TabPages.Remove(tabpage);
            }
  
        }




        private void btnSaveEdits_Click(object sender, EventArgs e)
        {
            _ctx.SaveChanges();
        }

        private void dgLineItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dv = (DataGridView)sender;
            DataGridViewRow  row = dv.CurrentRow;
 
            PurchaseLineItem item = (PurchaseLineItem)row.DataBoundItem;
            if (item.AmountReceived  >= item.Qnty)
            {item.Recieved = true;}
            else
            { item.Recieved = false; }
 
            if (item.Recieved == true)
            {
                item.AmountReceived = item.Qnty;
            }

            
        }

       

        
        // Print the item from the Order.
        private void button1_Click(object sender, EventArgs e)
        {
            string jobName = _purchaseOrder.Job.Jobname;
            string recvDate = DateTime.Today.ToShortDateString();
            
            foreach (PurchaseLineItem item in _purchaseOrder.PurchaseLineItem.ToList())
            {
             ThermalLabel tLabel =  lbService.GenerateInventoryLabel(item.LineId.ToString(),jobName,recvDate);
             lbService.PrintLabel(tLabel);

            }       
        }
        // Close the Active Tab
        private void button2_Click(object sender, EventArgs e)
        {
            TabPage tabpage = (TabPage)this.Parent;
            TabControl tabControl = (TabControl)tabpage.Parent;
            tabControl.TabPages.Remove(tabpage);
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {

        }

       
    }
}
