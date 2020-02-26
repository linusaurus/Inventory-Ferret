using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Entities;

namespace Weaselware.InventoryFerret
{
    public class Processing
    {

        public static void RecieveOrder(PurchaseOrder order, BadgerDataModel ctx)
        {

            OrderReciept receipt = new OrderReciept();
            receipt.OrderNum = order.OrderNum;
            receipt.ReceiptDate = DateTime.Today;
            receipt.EmployeeId = 8;
            ctx.OrderReciept.Add(receipt);
            ctx.SaveChanges();

            foreach (PurchaseLineItem item in order.PurchaseLineItem)
            {
                Inventory inv = new Inventory();

                inv.OrderReceiptID = receipt.OrderReceiptId;
                inv.LineId = item.LineId;
                if (item.PartId.HasValue) { inv.PartId = item.PartId.Value; }
                inv.JobId = item.PurchaseOrderId.Value;
                inv.DateStamp = DateTime.Today;
                if(item.AmountReceived.HasValue)inv.Qnty = item.AmountReceived.Value;
                //inv.Note = item.N
                inv.Description = item.Description.ToString();
                if (inv.UnitOfMeasure.HasValue) { inv.UnitOfMeasure = item.Uom; }
                receipt.Inventory.Add(inv);
               
            }

            order.Recieved = true;
            order.RecievedDate = DateTime.Today;
            ctx.SaveChanges();

            //// Push the new Order Receipt to The New Tab
            //MainFrm f = (MainFrm)Application.OpenForms["MainFrm"];
            //TabControl.TabPageCollection col = f.tabMain.TabPages;

            //TabPage orderReceiptPage = new TabPage();
            //orderReceiptPage.Text = "Order Receipt -> " + receipt.OrderReceiptID.ToString();
            //OrderReceiptControl control = new OrderReceiptControl(receipt,ctx);
            //control.Dock = DockStyle.Fill;
            //orderReceiptPage.Controls.Add(control);
            //col.Add(orderReceiptPage);
            //f.tabMain.SelectedTab = orderReceiptPage;
 
                
        }
    }
}
