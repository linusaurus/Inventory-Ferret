using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer.Entities;
using System.Threading.Tasks;

namespace Weaselware.InventoryFerret {



    public class RecievingManager {

       
        public void RecieveOrder(PurchaseOrder order, BadgerDataModel context) {
            if (order != null)
            {


                 OrderReciept receipt = new OrderReciept();
                receipt.EmployeeId = 8;
                receipt.ReceiptDate = DateTime.Today;
                receipt.OrderNum = order.OrderNum;
                context.OrderReciept.Add(receipt);
                order.Recieved = true;
                order.RecievedDate = DateTime.Today;
                context.SaveChanges();

                foreach (PurchaseLineItem i in order.PurchaseLineItem)
                {


                    Inventory inv = new Inventory();
                    inv.OrderReceiptID = receipt.OrderReceiptId;
                    inv.LineId = i.LineId;
                    inv.JobId = i.JobId;
                    if (i.Description != null) inv.Description = i.Description;
                    if (i.PartId.HasValue)
                    {
                        Part lookupPart = context.Part.Where(p => p.PartId == i.PartId).FirstOrDefault();
                        inv.UnitOfMeasure = lookupPart.Uid;
                        inv.PartId = i.PartId;
                    }

                    if (i.Qnty.HasValue) inv.Qnty = i.Qnty;

                    context.Inventory.Add(inv);

                }
            }
        }
    }
}
