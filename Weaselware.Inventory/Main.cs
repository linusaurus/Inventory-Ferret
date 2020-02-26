using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entities;



namespace Weaselware.InventoryFerret {
    public partial class Main : Form
    {

        BadgerDataModel _context;
        int _loggedOnUserID;
        

        public int LoggedOnUserID
        {
            get { return _loggedOnUserID; }
            set { _loggedOnUserID = value; }
        }
        
        public Main()
        {
            InitializeComponent();
            _context = new BadgerDataModel();

        }

        public TabControl GetTabControl()
        {
            return this.MainTabControl;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
            this.toolStripStatusLabel1.Text = "UserID=" + _loggedOnUserID.ToString() ;
            _context = new BadgerDataModel();
            
                var emp = _context.Employee.Where(p => p.EmployeeId == LoggedOnUserID).FirstOrDefault();
                this.toolStripStatusLabel1.Text = "User= " + emp.Firstname + " " + emp.Lastname;

           // Purchase Order Page
             MainTabControl.TabPages.Add(PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.PurchaseOrderPage));
           // MainTabControl.TabPages.Add(PageFactory.GetNewTabPage(_context,PageFactory.TabPageType.SupplierOrdersPage));

           // MainTabControl.TabPages.Add(PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.JobOrdersPage));
           // MainTabControl.TabPages.Add(PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.ItemSearchPage));
           // MainTabControl.TabPages.Add(PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.RecieptManagerPage));
           

        }

        private void MaintabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            if (tabControl.TabPages.Count > 0)
            {
                this.toolStripStatusLabel1.Text = tabControl.SelectedTab.Text;
                Mediator.GetInstance().OnTabChanged(tabControl, tabControl.SelectedTab);
            }
            
        }

        #region ToolBar Clicks
        private void tsSettingsButton_Click(object sender, EventArgs e) {

            LabelService lbService = new LabelService();
            lbService.SetPrintingOption();
        }

        private void tsScanBarCode_Click(object sender, EventArgs e) {

            TabPage searchPage =  PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.ItemSearchPage);
            
            MainTabControl.TabPages.Add(searchPage);
            MainTabControl.SelectedTab = searchPage;
        }

        private void tsPartEditor_Click(object sender, EventArgs e)
        {
            TabPage partEditorPage = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.PartEditorPage);
            MainTabControl.TabPages.Add(partEditorPage);
            MainTabControl.SelectedTab = partEditorPage;
        }

        private void tsbReject_Click(object sender, EventArgs e)
        {
            TabPage claimRejectPage = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.RejectPage);
            MainTabControl.TabPages.Add(claimRejectPage);
            MainTabControl.SelectedTab = claimRejectPage;
        }

        #endregion

        private void tsbPullStockOrder_Click(object sender, EventArgs e) {

            TabPage stockBillPage = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.StockBill);

            MainTabControl.TabPages.Add(stockBillPage);
            MainTabControl.SelectedTab = stockBillPage;

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == (Keys.F7))
            {
                this.tsScanBarCode.PerformClick();
            }
            if (keyData == (Keys.F8))
            {
                this.tsbJobItems.PerformClick();
            }
            if (keyData == (Keys.Escape))
            {              
                TabPage tabpage = MainTabControl.SelectedTab;
                if (tabpage.Text != "Supplier Orders")  
                {
                    if (tabpage.Text != "Job Orders")
                    {
                        if (tabpage.Text != "Order Reciepts")
                        {
                            MainTabControl.TabPages.Remove(tabpage);
                        }
                    }                   
                }              
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        /// <summary>
        /// New Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsOrderButton_Click(object sender, EventArgs e)
        {
          //  TestForm orderFrm = new TestForm(_context);
          //  orderFrm.Show();

        }

        private void mainToolStrip_MouseEnter(object sender, EventArgs e)
        {
            ToolStrip ts = ((ToolStrip)sender);
            ToolStripButton tsb = (ToolStripButton)ts.GetItemAt(395, 792);
        }

        private void mainToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbReceiveOrder_Click(object sender, EventArgs e)
        {
            TabPage suppliersTab = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.SupplierOrdersPage);
            MainTabControl.TabPages.Add(suppliersTab);
            MainTabControl.SelectedTab = suppliersTab;
        }

        private void tsbJobItems_OnClick(object sender, EventArgs e)
        {
            TabPage AssembliesTab = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.AssemblyManagerControl);
            MainTabControl.TabPages.Add(AssembliesTab);
            MainTabControl.SelectedTab = AssembliesTab;
        }
    }
}
