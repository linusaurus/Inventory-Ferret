using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using BadgerData;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using DataLayer.Models;

namespace Weaselware.InventoryFerret
{
    public class ResourceRepository
    {
        readonly BadgerDataModel ctx;

        public ResourceRepository()
        {
            ctx = new BadgerDataModel();
        }

        public  Resource Find(int resourceID)
        {
            return  ctx.Resource.Find(resourceID);
        }

        public Resource LoadResource(int resourceID)
        {
            return ctx.Resource.Where(r => r.ResourceID == resourceID).FirstOrDefault();
        }

        public void CreateOrUpdateOrder(OrderDetailDto orderDTO)
        {
            //var ctx = context;
            var order = ctx.PurchaseOrder.FirstOrDefault(o => o.OrderNum == orderDTO.PurchaseOrderID);
            if (order == null)
            {
                order = new PurchaseOrder();
                ctx.PurchaseOrder.Add(order);
            }

            //Map properties
            order.OrderDate = DateTime.Parse(orderDTO.OrderDate);
            order.OrderTotal = orderDTO.OrderTotal;
            order.ExpectedDate = orderDTO.ExpectedDate;
            order.JobId = orderDTO.JobID;
            order.Memo = orderDTO.Memo;

            order.SalesRep = orderDTO.SalesRep;
            order.EmployeeId = orderDTO.EmployeeID;
            order.OrderNum = orderDTO.PurchaseOrderID;
            order.ShipId = orderDTO.ShipID;
            order.ShippingCost = orderDTO.ShippingCost;
            order.SubTotal = orderDTO.SubTotal;
            order.SupplierId = orderDTO.SupplierID;
            order.SuppressTax = orderDTO.Taxable;

            order.Tax = orderDTO.Tax;
            order.TaxRate = orderDTO.TaxRate;

            //remove deleted details -
            order.PurchaseLineItem
            .Where(d => !orderDTO.LineItems.Any(LineItemDto => LineItemDto.LineID == d.LineID)).ToList()
            .ForEach(deleted => ctx.PurchaseLineItem.Remove(deleted));

            //update or add details
            orderDTO.LineItems.ToList().ForEach(detailDTO =>
            {
                var detail = order.PurchaseLineItem.FirstOrDefault(d => d.LineID == detailDTO.LineID);
                if (detail == null)
                {
                    detail = new PurchaseLineItem();
                    order.PurchaseLineItem.Add(detail);
                }
                detail.JobId = detailDTO.JobID;
                detail.Qnty = detailDTO.Quantity;
                detail.Description = detailDTO.Description;
                detail.PurchaseOrderId = detailDTO.PurchaseOrderID;
                detail.PartID = detailDTO.PartID;
                detail.UnitCost = detailDTO.Price;
                detail.Uom = detailDTO.UiD;
                detail.Extended = detailDTO.Extended;

            });

            //remove deleted orderfees -
            order.OrderFee
                .Where(d => !orderDTO.OrderFees.Any(OrderFeeDto => OrderFeeDto.OrderFeeID == d.OrderfeeID)).ToList()
                .ForEach(deleted => ctx.OrderFee.Remove(deleted));

            //update or add OrderFees
            orderDTO.OrderFees.ToList().ForEach(od =>
            {
                var orderfee = order.OrderFee.FirstOrDefault(r => r.OrderfeeID == od.OrderFeeID);
                if (orderfee == null)
                {
                    orderfee = new OrderFee();
                    order.OrderFee.Add(orderfee);
                }
                orderfee.PurchaseOrderID = order.OrderNum;
                orderfee.FeeName = od.FeeName;
                orderfee.Cost = od.Cost;
                orderfee.Extension = od.Extension;
                orderfee.Qnty = od.Qnty;
            });

            //remove deleted attachments -
            order.Attachment
                .Where(a => !orderDTO.Attachments.Any(attachDTO => attachDTO.AttachmentID == a.AttachmentId)).ToList()
                .ForEach(deleted => ctx.Attachment.Remove(deleted));
            //update or add Attachments
            orderDTO.Attachments.ToList().ForEach(ad =>
            {
                var attachmnt = order.Attachment.FirstOrDefault(r => r.AttachmentId == ad.AttachmentID);
                if (attachmnt == null)
                {
                    attachmnt = new Attachment();
                    order.Attachment.Add(attachmnt);
                }

                attachmnt.OrderNum = ad.OrderNum;
                attachmnt.Filesource = ad.FileSource;
                attachmnt.AttachmentDescription = ad.AttachmentDescription;
                attachmnt.Ext = ad.Ext;
                attachmnt.Src = ad.Src;
                attachmnt.FileSize = ad.FileSize;
                attachmnt.Creator = ad.Creator;
                attachmnt.CreateDate = ad.CreatedDate;
            });

            ctx.SaveChanges();
        }
    }
}
