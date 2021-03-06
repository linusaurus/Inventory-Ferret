﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entities;
using DataLayer.Models;
using DataLayer.Services;
using System.Drawing;
using Weaselware.InventoryFerret.UserControls;

namespace Weaselware.InventoryFerret {
    public partial class Main : Form
    {

        BadgerDataModel _context;
        int _loggedOnUserID;
        readonly OrdersService _ordersService;
        
        public TabControl MainTabs {get;set;}

        public int LoggedOnUserID
        {
            get { return _loggedOnUserID; }
            set { _loggedOnUserID = value; }
        }
        
        public Main()
        {
            InitializeComponent();
            // This should be the main contect wireup for everything else
            _context = new BadgerDataModel();
            _ordersService = new OrdersService(_context);
            MainTabs = MainTabControl;
            Mediator.GetInstance().OrderOpen += Main_OrderOpen;
        }

        public  TabControl GetTabControl()
        {
            return this.MainTabControl;
        }

        private void Main_Load(object sender, EventArgs e)
        {

            closeImage = Properties.Resources.baseline_close_black_18dp;
            MainTabs.Padding = new System.Drawing.Point(26, 4);

            this.toolStripStatusLabel1.Text = "UserID=" + _loggedOnUserID.ToString() ;
            _context = new BadgerDataModel();
            
                var emp = _context.Employee.Where(p => p.EmployeeId == LoggedOnUserID).FirstOrDefault();
                this.toolStripStatusLabel1.Text = "User= " + Globals.CurrentUserName;
               // Globals.CurrentUserName = emp.Firstname + " " + emp.Lastname;
                TabPage myOrdersTab = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.MyOrdersPage);
                myOrdersTab.Name = "myOrdersTab";
                MainTabControl.TabPages.Add(myOrdersTab);
               
 

        }

        //Region Global new tab generator --------------------

        public void OpenAnOrder(int orderID)
        {
            TabPage page = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.PurchaseOrderPage, orderID);
            MainTabControl.TabPages.Add(page);
            MainTabControl.SelectedTab = page;
        }

        private void Main_OrderOpen(object sender, OrderChangedArgs e)
        {
            MainTabControl.TabPages.Add(PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.PurchaseOrderPage, e.Order.OrderNum));
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

        #endregion

        private void tsbPullStockOrder_Click(object sender, EventArgs e) {

            TabPage stockBillPage = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.StockBill);

            MainTabControl.TabPages.Add(stockBillPage);
            MainTabControl.SelectedTab = stockBillPage;

        }

        private void CloseActiveTab()
        {
            TabPage tabpage = MainTabControl.SelectedTab;
            if (MainTabControl.TabPages.Count > 1)
            {
                // Need to determine is the page is Order, and is not Dirty
                if (tabpage.Name == "Order")
                {
                    if (((OrderEditSplitPanelControl)tabpage.Controls[0]).IsDirty == true)
                    {
                        DialogResult dlg = MessageBox.Show("Save changes?", "Question", MessageBoxButtons.YesNo);

                        if (dlg == DialogResult.Yes)
                        {
                            // -- UserCOntrol public save method ---
                            ((OrderEditSplitPanelControl)tabpage.Controls[0]).SaveChanges();
                            MainTabControl.TabPages.Remove(tabpage);
                        }
                        if (dlg == DialogResult.No)
                        { MainTabControl.TabPages.Remove(tabpage); }

                    }
                    else
                    { MainTabControl.TabPages.Remove(tabpage); }
                                         
                }
                else
                {MainTabControl.TabPages.Remove(tabpage);}   
            }
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
                CloseActiveTab();       
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
     
        private void mainToolStrip_MouseEnter(object sender, EventArgs e)
        {
            ToolStrip ts = ((ToolStrip)sender);
            ToolStripButton tsb = (ToolStripButton)ts.GetItemAt(395, 792);
        }

        private void tsbJobItems_OnClick(object sender, EventArgs e)
        {
            TabPage AssembliesTab = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.AssemblyManagerControl);
            MainTabControl.TabPages.Add(AssembliesTab);
            MainTabControl.SelectedTab = AssembliesTab;
        }

        private void tsbFindOrder_Click(object sender, EventArgs e)
        {
            TabPage AssembliesTab = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.PurchaseOrdersPage);
            MainTabControl.TabPages.Add(AssembliesTab);
            MainTabControl.SelectedTab = AssembliesTab;
        }

        private void MainTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Image img = new Bitmap(closeImage);
            Rectangle r = e.Bounds;
            r = this.MainTabs.GetTabRect(e.Index);
            r.Offset(2, 2);
            Brush TitleBrush = new SolidBrush(Color.Black);
            Font f = this.Font;
            string title = this.MainTabs.TabPages[e.Index].Text;
            e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));
            e.Graphics.DrawImage(img, new Point(r.X + (this.MainTabs.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));
        }

        private void MainTabControl_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.MainTabs.GetTabRect(tabControl.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.MainTabs.GetTabRect(tabControl.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (MainTabs.SelectedIndex >= 0)
            {
                if (r.Contains(p))
                {
                    TabPage tabPage = (TabPage)tabControl.TabPages[tabControl.SelectedIndex];
                    CloseActiveTab();
                }
            }
        }

        private void mainToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tsOrderButton":

                    var jobID = 0;
                    var supplierID = 0;

                    NewOrderDialog diag = new NewOrderDialog(_context);
                    if (diag.ShowDialog() == DialogResult.OK)
                    {
                        jobID = diag.JobNumber;
                        supplierID = diag.SupplierID;

                        var order = _ordersService.NewDefault(LoggedOnUserID, supplierID, jobID);
                        _ordersService.Add(order);
                        // Purchase Order Page
                        MainTabControl.TabPages.Add(PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.PurchaseOrderPage, order.OrderNum));
                    }

                    break;
                /// My Orders -------+
                case "tsMyOrders":

                    TabPage myOrdersTab = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.MyOrdersPage);
                    myOrdersTab.Name = "myordersTab";

                    if (!MainTabControl.TabPages.ContainsKey("myordersTab"))
                    {
                        MainTabControl.TabPages.Add(myOrdersTab);
                        MainTabControl.SelectedTab = myOrdersTab;
                    }
                    else
                    {
                        if (MainTabControl.TabPages.ContainsKey("myordersTab"))
                        { MainTabControl.SelectTab("myordersTab"); }
                    }

                    

                    break;
                case "tsSupplerOrders":


                    break;
                case "tsbReceiveOrder":

                    TabPage suppliersTab = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.SupplierOrdersPage);
                    suppliersTab.Name = "SupplierTab";
                    if (!MainTabControl.TabPages.ContainsKey("SupplierTab"))
                    {
                        MainTabControl.TabPages.Add(suppliersTab);
                        MainTabControl.SelectedTab = suppliersTab;
                    }
                    else
                    {
                        if (MainTabControl.TabPages.ContainsKey("SupplierTab"))
                        { MainTabControl.SelectTab("SupplierTab"); }  
                    }


                    break;

                case "tsPartEditor":

                    TabPage partEditorPage = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.PartEditorPage); ;
                    partEditorPage.Name = "partEditorPage";

                    if (!MainTabControl.TabPages.ContainsKey("partEditorPage"))
                    {
                        MainTabControl.TabPages.Add(partEditorPage);
                        MainTabControl.SelectedTab = partEditorPage;
                    }
                    else
                    {
                        if (MainTabControl.TabPages.ContainsKey("partEditorPage"))
                        { MainTabControl.SelectTab("partEditorPage"); }
                    }

                    break;

                case "tsbJobOrders":

                    TabPage jobOrdersPage = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.JobOrdersPage);
                        
                    jobOrdersPage.Name = "JobOrderPage";
                    if (!MainTabControl.TabPages.ContainsKey("JobOrderPage"))
                    {
                        MainTabControl.TabPages.Add(jobOrdersPage);
                        MainTabControl.SelectedTab = jobOrdersPage;
                    }
                    else
                    {
                     if(MainTabControl.TabPages.ContainsKey("JobOrderPage"))
                        { MainTabControl.SelectTab("JobOrderPage"); }
  
                    }
                    

                    break;
                default:
                    break;

            }
        }
    }
}
