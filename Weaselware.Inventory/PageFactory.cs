﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DataLayer.Entities;
using Weaselware.InventoryFerret.UserControls;

namespace Weaselware.InventoryFerret
{
    public class PageFactory
    {
        public enum TabPageType
        {
            SupplierOrdersPage,
            PurchaseOrdersPage,
            OrderPage,
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
        
        public static TabPage GetNewTabPage(BadgerDataModel ctx,TabPageType pageType,object model = null)
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
                case TabPageType.PurchaseOrdersPage:
                    tab.Text = "Purchase Order";
                    PurchaseOrderControl po = new PurchaseOrderControl(new PurchaseOrder());
                    po.Dock = DockStyle.Fill;
                    tab.Controls.Add(po);
                    break;
                case TabPageType.OrderPage:
                    tab.Text = "Order";
                    PurchaseOrderControl poctr = new PurchaseOrderControl(new PurchaseOrder());
                    poctr.Dock = DockStyle.Fill;
                    tab.Controls.Add(poctr);

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
                     tab.Text = "Job Orders";
                     JobOrdersControl jobControl = new JobOrdersControl(ctx);
                     jobControl.Dock = DockStyle.Fill;
                     tab.Controls.Add(jobControl);
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
                case TabPageType.PartDetailEdit:
                    {
                        if (model is Part)
                        {
                            Part p = model as Part;
                            tab.Text = $"Part Edit : {p.PartID.ToString()}";
                            PartView ctr = new PartView(p,ctx);
                            ctr.Dock = DockStyle.Fill;
                            tab.Controls.Add(ctr);
                        }
             
                    }
                    break;
                case TabPageType.PurchaseOrderPage:
                    {
                    var order = (PurchaseOrder)model;
                    tab.Text = $"Purchase Order :{order.OrderNum.ToString()}";
                    PurchaseOrderControl ctr = new PurchaseOrderControl(ctx,model as PurchaseOrder);
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
