﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DataLayer.Entities;
using Weaselware.InventoryFerret.UserControls;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Weaselware.UserControls;

namespace Weaselware.InventoryFerret
{
    public class PageFactory
    {
        public enum TabPageType
        {
            SupplierOrdersPage,
            PurchaseOrdersPage,
            MyOrdersPage,
            OrderRecieptPage,
            ItemSearchPage,
            RecieptManagerPage,
            LabelEditorPage,
            JobOrdersPage,
            StockBill,
            PartEditorPage,
            PartDetailEdit,
            PurchaseOrderPage,
            AssemblyManagerControl

        }
        
        public static TabPage GetNewTabPage(BadgerDataModel ctx,TabPageType pageType,int key = 0)
        {
            TabPage tab = new TabPage();

            switch (pageType)
            {
                case TabPageType.SupplierOrdersPage:
                    {
                        tab.Text = "Supplier Orders";
                        tab.Name = "SupplierOrders";
                        SupplierOrdersControl ctr = new SupplierOrdersControl(ctx);
                        ctr.Dock = DockStyle.Fill;
                        tab.Controls.Add(ctr);
                    }
                    break;
                // Order Seach/Display Page
                case TabPageType.PurchaseOrdersPage:
                    tab.Text = "Orders Manager";
                    OrderManager po = new OrderManager(ctx);
                    po.Dock = DockStyle.Fill;
                    tab.Controls.Add(po);
                    break;
                case TabPageType.MyOrdersPage:
                    tab.Text = "Order";
                    tab.Name = "myOrdersPage";
                    MyOrdersControl myOrdersPage = new MyOrdersControl(ctx,Globals.CurrentLoggedUserID);
                    myOrdersPage.Dock = DockStyle.Fill;
                    tab.Controls.Add(myOrdersPage);

                    break;
                case TabPageType.OrderRecieptPage:
                     tab.Text = "Recieve Order";
                     OrderReceiptControl orderctr = new OrderReceiptControl(ctx);
                     orderctr.Dock = DockStyle.Fill;
                    tab.Controls.Add(orderctr);
                    break;
                case TabPageType.ItemSearchPage:
                    tab.Text = "Item Search";
                    ItemSearchControl searchctr = new ItemSearchControl(ctx);
                    searchctr.Dock = DockStyle.Fill;
                    tab.Controls.Add(searchctr);
                    break;
                case TabPageType.JobOrdersPage:
                     
                     TabPage jobTab = new TabPage("Job Orders");
                     JobOrdersControl jobControl = new JobOrdersControl(ctx);
                     jobControl.Dock = DockStyle.Fill;
                     jobTab.Controls.Add(jobControl);
                    return jobTab;
                    break;
                case TabPageType.RecieptManagerPage:
                    tab.Text = "Order Reciepts";
                    OrderReceiptsControl recieptsManagerControl = new OrderReceiptsControl(ctx);
                    recieptsManagerControl.Dock = DockStyle.Fill;
                    tab.Controls.Add(recieptsManagerControl);
                    break;
                case TabPageType.StockBill:
                    tab.Text = "Stock Bill";
                    StockBill stockBillControl = new StockBill(ctx);
                    stockBillControl.Dock = DockStyle.Fill;
                    tab.Controls.Add(stockBillControl);
                    break;
                case TabPageType.AssemblyManagerControl:
                    tab.Text = "Products";
                    AssemblyManagerControl assemblyManagerControl = new AssemblyManagerControl(ctx);
                    assemblyManagerControl.Dock = DockStyle.Fill;
                    tab.Controls.Add(assemblyManagerControl);
                    break;
                case TabPageType.PartEditorPage:
                    tab.Text = "Part Editor";
                    PartEditor partEditorControl = new PartEditor(ctx);
                    partEditorControl.Dock = DockStyle.Fill;
                    tab.Controls.Add(partEditorControl);
                  
                    break;
                
                // Open Part for Detailed Editing w/ resource --
                case TabPageType.PartDetailEdit:
                    {

                        if (key != 0)
                        {
                            Part p = ctx.Part.Find(key);
                            if (p != null)
                            {
                                tab.Text = $"Part Edit : {p.PartID.ToString()}";
                                PartView ctr = new PartView(p, ctx);
                                ctr.Dock = DockStyle.Fill;
                                tab.Controls.Add(ctr);

                            }
                        }
                        // This is a new Part
                        else
                        {
                            tab.Text = $"Part Edit : {"New*"}";
                            Part newPart;
                            using ( var partService = new DataLayer.Services.PartsService(ctx))
                            {
                               newPart = partService.New();
                            }
                            PartView ctr = new PartView(newPart, ctx);
                            ctr.Dock = DockStyle.Fill;
                            tab.Controls.Add(ctr);
                        }
                        
                    }
                    break;
                case TabPageType.PurchaseOrderPage:
                    {                        
                         tab.Text = $"Purchase Order :{key}";
                         tab.Name = "Order";
                        // OrderEditControl ctr = new OrderEditControl();
                        OrderEditSplitPanelControl ctr = new OrderEditSplitPanelControl();
                         ctr.SetDataSource(ctx,key);
                        // ctr.LoadByID(key);
                         ctr.Dock = DockStyle.Fill;
                         tab.Controls.Add(ctr);                
                    }
                    break;

                default:
                    break;
            }
            return tab;
        }
    }
}
