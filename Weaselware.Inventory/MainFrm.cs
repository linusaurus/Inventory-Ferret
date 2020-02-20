using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neodynamic.SDK.Printing;
using Neodynamic.Windows.ThermalLabelEditor;
using System.Windows.Forms;
using BadgerData;


namespace Weaselware.InventoryFerret
{
    public partial class MainFrm : Form
    {

        BadgerData.BadgerDataModel _context = new BadgerDataModel();
        
        //Model1 _context;
        BindingSource bsItems = new BindingSource();
        BindingSource bsOrders = new BindingSource();
        BindingSource bsJobItems = new BindingSource();
        BindingSource bsSuppliersItems = new BindingSource();

        List<PurchaseLineItem> items;
        List<Supplier> supplier;
        List<PurchaseOrder> supplierOrders;
      
        PurchaseOrder selectedOrder;
        Supplier selectedSupplier;
        Job selectedJob;
        private TabControl tb;

        int recieverID = 8;

        Neodynamic.SDK.Printing.PrinterSettings psettings;

  
        public Object TabContainer
        {
            get { return this.tabMain; }
        }
        
        public MainFrm()
        {
            InitializeComponent();
            this.dgLineItems.AutoGenerateColumns = false;
            this.dgJobItems.AutoGenerateColumns = false;
            this.dgJobItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgJobItems.Columns[1].DefaultCellStyle.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.dgJobItems.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            lvSuppliersOrders.MultiSelect = false;
            this.dgSupplierItems.AutoGenerateColumns = false;
            psettings = Properties.Settings.Default.PrinterSetting;
            ThermalLabel.LicenseOwner = "Richard Young-Standard Edition-Developer License";
            ThermalLabel.LicenseKey = "MC4J7E7UM8BDLXA72PEWSJ84NR5FXRVBKPANLSYTCCGKKNMW9N6A";
            this.tabMain.SelectedIndexChanged += tabMain_SelectedIndexChanged;
        }

        void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tb = (TabControl)sender;
            Mediator.GetInstance().OnTabChanged(this.tabMain,tb.SelectedTab);
            this.toolStripStatusLabel1.Text = tb.SelectedTab.Text;
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            //_context = new Model1();
            _context = new BadgerDataModel();
            _context.Database.Connection.Open();

            var query = from c in _context.PurchaseOrders where (c.Recieved != true) orderby c.OrderNum descending  select c;
            bsOrders.DataSource = query.ToList();
            lbOrders.DisplayMember = "OrderNum";
            lbOrders.DataSource = bsOrders;
            txtSearchSuppliers.Text = Properties.Settings.Default.LastSupplierSearch.ToString();
        }

  
        private void LoadItems(int lineID)
        {
            var query = from c in _context.PurchaseLineItems where c.PurchaseOrderID == lineID select c;           
            items = query.ToList();
            bsItems.DataSource = items;
            this.dgLineItems.DataSource = bsItems;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {    
            bsItems.EndEdit();
            _context.SaveChanges();
        }



        // Item Selected in Orders List Box Loads LineItems for Edit
        private void lbOrders_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            if (lb.SelectedItem != null)
            {
                int orderNo = ((PurchaseOrder)lb.SelectedItem).OrderNum;
                selectedOrder = (PurchaseOrder)lb.SelectedItem;
                this.Text = "Inventory Manager : " + orderNo.ToString();
                LoadItems(orderNo);
                Mediator.GetInstance().OnOrderChanged(this, selectedOrder);
                
            }

        }
        //Open Dialog modal editor to process LineItems to Inventory
        private void btnRecieve_Click(object sender, EventArgs e)
        {
            // Create an OrderReceipt-Get ID
            OrderReciept oReciept = new OrderReciept();
            oReciept.EmployeeID = recieverID;
            oReciept.ReceiptDate = DateTime.Today;
            oReciept.OrderNum = selectedOrder.OrderNum;
            _context.OrderReciepts.Add(oReciept);
            _context.SaveChanges();
           
            // Cycle though all the lineitems
            foreach (PurchaseLineItem item in items)
            {
                
                Inventory inv = new Inventory();
                inv.Qnty = item.Qnty.Value;
                inv.DateStamp = DateTime.Today;
                inv.LineID = item.LineID;
                inv.JobID = selectedOrder.Job_id.Value;
                inv.OrderReceiptID = oReciept.OrderReceiptID;
                if(item.PartID.HasValue) inv.PartID =  item.PartID.Value ;
                inv.Qnty = item.Qnty.Value;
                inv.Description = item.Description;
                inv.UnitOfMeasure = (item.Uom.HasValue) ? inv.UnitOfMeasure = item.Uom : inv.UnitOfMeasure = -1;
                _context.Inventories.Add(inv);
               
            }

            _context.SaveChanges();
        }

        private void BlowNGo(int option)
        {
            // Create an OrderReceipt-Get ID
            OrderReciept oReciept = new OrderReciept();
            oReciept.EmployeeID = recieverID;
            oReciept.ReceiptDate = DateTime.Today;
            oReciept.OrderNum = selectedOrder.OrderNum;
            _context.OrderReciepts.Add(oReciept);
            _context.SaveChanges();
            //----- Consume Items No impact on inventory
            if (option == 0)
            {            
                // Cycle though all the lineitems
                foreach (PurchaseLineItem item in items)
                {

                    Inventory inv = new Inventory();
                    inv.Qnty = item.Qnty.Value;
                    inv.DateStamp = DateTime.Today;
                    inv.LineID = item.LineID;
                    inv.JobID = selectedOrder.Job_id.Value;
                    inv.OrderReceiptID = oReciept.OrderReceiptID;
                    if (item.PartID.HasValue) inv.PartID = item.PartID.Value;
                    inv.Qnty = item.Qnty.Value;
                    inv.Description = item.Description;
                    inv.UnitOfMeasure = (item.Uom.HasValue) ? inv.UnitOfMeasure = item.Uom : inv.UnitOfMeasure = -1;
                    _context.Inventories.Add(inv);
                }

             }
            // ----Push the item qntys to inventory
            if (option == 1)
            {
                // Cycle though all the lineitems
                foreach (PurchaseLineItem item in items)
                {

                    Inventory inv = new Inventory();
                    inv.Qnty = item.Qnty.Value;
                    inv.DateStamp = DateTime.Today;
                    inv.LineID = item.LineID;
                    inv.JobID = selectedOrder.Job_id.Value;
                    inv.OrderReceiptID = oReciept.OrderReceiptID;
                    if (item.PartID.HasValue) inv.PartID = item.PartID.Value;
                    inv.Qnty = item.Qnty.Value;
                    inv.Description = item.Description;
                    inv.UnitOfMeasure = (item.Uom.HasValue) ? inv.UnitOfMeasure = item.Uom : inv.UnitOfMeasure = -1;
                    _context.Inventories.Add(inv);

                }

            }



            _context.SaveChanges();
        }

        private void tbOrderItems_Click(object sender, EventArgs e)
        {

        }
        // Simply flushes the items to Inventory
        private void btnBlowNGo_Click(object sender, EventArgs e)
        {

        }

        private void txtJobSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string searchTxt = tb.Text;
            var query = from c in _context.Jobs where c.jobname.StartsWith(searchTxt) select c;
            List<Job> jobsList = query.ToList();
            lbJobs.DisplayMember = "Jobname";
            lbJobs.DataSource = jobsList;

          
        }

        private void lbJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            selectedJob = (Job)lb.SelectedItem;
            int jobKey = selectedJob.job_id;
            this.Text = "Inventory Manager : " + selectedJob.jobname;

            var query = from c in _context.PurchaseLineItems where c.JobID == jobKey orderby(c.LineID) descending  select c;

            List<PurchaseLineItem> item = query.ToList() ;
            bsJobItems.DataSource = item;
            dgJobItems.DataSource = bsJobItems;

        }

        private void ReturnJobItem(Job job,string searchtxt,int filter)
        {
            int jobKey = 0;
            if (job != null)
            {
                jobKey = selectedJob.job_id;

            }
            if (jobKey > 0)
            {
                var query = from c in _context.PurchaseLineItems where (c.JobID == jobKey && c.Description.Contains(searchtxt)) select c;
                List<PurchaseLineItem> item = query.ToList();
                bsJobItems.DataSource = item;
                dgJobItems.DataSource = bsJobItems;
            }
        }

        private void txtSearchInDescription_TextChanged(object sender, EventArgs e)
        {
            int jobKey = 0; 
            if (selectedJob != null) 
            {  
                jobKey = selectedJob.job_id;
            
            }
            if (jobKey > 0)
            {
                TextBox tb = (TextBox)sender;
                string searchTxt = tb.Text;


                var query = from c in _context.PurchaseLineItems where (c.JobID == jobKey && c.Description.Contains(searchTxt)) select c;
                List<PurchaseLineItem> item = query.ToList();
                bsJobItems.DataSource = item;
                dgJobItems.DataSource = bsJobItems;
            }

        }

        private void chkJobHideRecived_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tbOrderReciepts;
        }

        private void tbFilterOrders_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int  ord;
            if(  int.TryParse(tb.Text, out ord))
            {
                var query = from c in _context.PurchaseOrders where c.OrderNum > ord select c;

                bsOrders.DataSource = query.ToList();
                lbOrders.DisplayMember = "OrderNum";
                lbOrders.DataSource = bsOrders;

            }

        }

        #region Suppliers

        private void txtSearchSuppliers_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string searchTxt = tb.Text;
            if (searchTxt.Length > 0)
            {
                var query = from c in _context.Suppliers where c.SupplierName.StartsWith(searchTxt) select c;
                supplier = query.ToList();
                bsSuppliersItems.DataSource = supplier;
                lbSuppliers.DisplayMember = "SupplierName";
                lbSuppliers.DataSource = supplier;
                Properties.Settings.Default.LastSupplierSearch = searchTxt.ToString();
                Properties.Settings.Default.Save();
            }
        }

        private void lbSupplierOrdersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            PurchaseOrder po = (PurchaseOrder)lb.SelectedItem;
            Text = po.OrderNum.ToString();
            int key = po.OrderNum;
            var query = from c in _context.PurchaseLineItems where c.PurchaseOrderID == key select c;
            dgSupplierItems.DataSource = query.ToList();
        }

        
        
        
        #endregion

        // Populate the Supplier Order List ---
        private void lbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
           List<PurchaseOrder> ordersList = new List<PurchaseOrder>();
           ListBox lb = (ListBox)sender;
           selectedSupplier = (Supplier)lb.SelectedItem;
            int key = selectedSupplier.SupplierID;
            if (selectedSupplier != null)
            {
                var query = from c in _context.PurchaseOrders where c.SupplierID == key orderby (c.OrderNum) descending select c;
                ordersList = query.ToList();
                supplierOrders = ordersList;

                lvSuppliersOrders.Items.Clear();
                foreach (PurchaseOrder p in ordersList)
                {

                    ListViewItem lvi = new ListViewItem(p.OrderNum.ToString().Trim());
                    lvi.SubItems.Add(((DateTime)p.OrderDate).Date.ToShortDateString());
                    lvi.SubItems.Add("Status");


                    lvSuppliersOrders.Items.Add(lvi);
                }
            }

        }

        private void lvSuppliersOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;
            if (lv.SelectedItems.Count > 0)
            {

            string temp = lv.SelectedItems[0].Text;
            Text = "Inventory Manager : " + temp;
            int orderNum;
                if (int.TryParse(temp,out orderNum))
                {
                    selectedOrder = (from c in _context.PurchaseOrders where (c.OrderNum == orderNum) select c).FirstOrDefault();
                    lblJobName.Text = selectedOrder.Job.jobname;

                    var query = from c in _context.PurchaseLineItems where c.PurchaseOrderID == orderNum select c;
                    dgSupplierItems.DataSource = query.ToList();
                
                }
            }

        }
        // Launch new tab and prepare the  the line Items for recieving
        private void button1_Click(object sender, EventArgs e)
        {           
            if (selectedOrder != null)
            {

                int orderNumber = selectedOrder.OrderNum;

                TabPage t = new TabPage("Receiving Order -> " + selectedOrder.OrderNum.ToString());
           
                PitemsGrid grid = new PitemsGrid();
                grid.SetDataSource(orderNumber, _context);
                grid.Dock = DockStyle.Fill;
                t.Controls.Add(grid);
                tabMain.TabPages.Add(t);
                tabMain.SelectedTab = t;

            }

        }


        #region Menus

        // Printed Dropdown Menu
        private void tsdbPrinter_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripDropDownButton dd = (ToolStripDropDownButton)sender;
            string pick = e.ClickedItem.Name;
            psettings = new Neodynamic.SDK.Printing.PrinterSettings();
            switch (pick)
            {
                case "printSettingsToolStripMenuItem": 
                    {
                        Weaselware.InventoryFerret.PrintJobDialog dialog = new Weaselware.InventoryFerret.PrintJobDialog();
                        //dialog.PrinterSettings = Properties.Settings.Default.PrinterSetting;
                        if (dialog.ShowDialog() == DialogResult.OK )
                        {
                            
                            psettings.PrinterName = dialog.PrinterSettings.PrinterName;
                            psettings.ProgrammingLanguage = dialog.PrinterSettings.ProgrammingLanguage;
                            psettings.Dpi = dialog.PrinterSettings.Dpi;
                            psettings.Communication.CommunicationType = dialog.PrinterSettings.Communication.CommunicationType;
                            Properties.Settings.Default.PrinterSetting = psettings;
                            Properties.Settings.Default.Save();
                        }
                       
                        break;

                    }
                case  "printSelectedLabelToolStripMenuItem":
                    {
                        break;
                    }
                default:
                    break;
            }
        }
        #endregion


        #region Labels

        private void PrintLabels(List<BadgerData.Inventory> invItems)
        {

        }

        #endregion

        private void pitemsGrid1_Load(object sender, EventArgs e)
        {

        }
    }
}
