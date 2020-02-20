using System;
using System.Collections.Generic;
using System.Linq;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;
using DataLayer.Entities;
using DataLayer.Models;

namespace DataLayer.Services {

    public class InventoryService : IDisposable, IInventoryService {

        BadgerDataModel context;

        public InventoryService(BadgerDataModel Context) {

            context = Context;
        }

        public bool Exist(int stockTransActionID) {

            bool result = false;
            if (context.Inventory.Any(c => c.StockTransactionId == stockTransActionID))
            {result = true; }

            return result;
        }

        public Inventory FindByLineItem(int lineID) {

            try
            {
                return context.Inventory.Where(c => c.LineId == lineID).FirstOrDefault();
            }
            catch (Exception)
            {

                throw new NullReferenceException();
            }
            
        }
        /// <summary>
        /// TODO this need refactoring to imporve preformance
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns></returns>
        public List<Inventory> GetSupplierInventory(Supplier supplier) {

            List<Inventory> result;

            var orderNums = context.PurchaseOrder.Where(c => c.SupplierId == supplier.SupplierId).Select(c => c.OrderNum);
            var reciepts = from rct in context.OrderReciept where (orderNums.Contains(rct.OrderNum.Value)) select rct.OrderReceiptId;
            var it = from r in context.Inventory where (reciepts.Contains(r.OrderReceiptId.Value)) select r;
            result = it.ToList();
            return result;

        }

        public List<Inventory> GetSupplierInventory(Supplier supplier, string itemName) {

            List<Inventory> result;

            var orderNums = context.PurchaseOrder.Where(c => c.SupplierId == supplier.SupplierId).Select(c => c.OrderNum);
            var reciepts = from rct in context.OrderReciept where (orderNums.Contains(rct.OrderNum.Value)) select rct.OrderReceiptId;
            var it = from r in context.Inventory where (reciepts.Contains(r.OrderReceiptId.Value) && r.Description.Contains(itemName)) select r;
            result = it.ToList();
            return result;
        }

        public List<Inventory> GetOrderRecieptItems(int orderRecieptID) {

            return context.Inventory.Where(c => c.OrderReceiptId == orderRecieptID).ToList();
        }
        /// <summary>
        /// Get Inventory Transaction for a Part
        /// </summary>
        /// <param name="partID"></param>
        /// <returns></returns>
       public List<InventoryListDto> GetInventoryByPartID(int partID) {


            var result = context.Inventory.Include(j => j.GetJob).Where(i => i.PartId == partID).Select(p => new InventoryListDto
            {
                StockTransactionId = p.StockTransactionId,
                Description = p.Description,
                PartId = p.PartId.GetValueOrDefault(),
                LineId = p.LineId.Value,
                OrderReceiptId = p.OrderReceiptId.GetValueOrDefault(),
                QntyRev = p.Qnty.GetValueOrDefault(),
                TransDate = p.DateStamp.Value.ToShortDateString(),
                JobName = p.GetJob.Jobname,
                TransactionType = p.TransActionType.GetValueOrDefault()

            }).OrderByDescending(o => o.StockTransactionId);


            return result.ToList();
    
        }


       public void InsertOrUpdate(Inventory inventory) {
            if (inventory.OrderReceiptId == default(int))
            {
                context.Entry(inventory).State = EntityState.Added;
                context.Inventory.Add(inventory);
            }
            else
            {context.Entry(inventory).State = EntityState.Modified;}
        
        }


        public void Save() {

            context.SaveChanges();
        }
        public void Dispose() {

            context.Dispose();
        }

        public List<Inventory> GetJobInventory(Job job) {

            List<Inventory> result = null;

            if (job?.JobId > 0)
            {
                int key = job.JobId;
                result =  context.Inventory.AsNoTracking().Where(j => j.JobId == job.JobId).ToList();

            }
            return result;
        }
        /// <summary>
        /// Push Stock-Increase stocklevel of part amount specified
        /// </summary>
        /// <param name="partID"></param>
        /// <param name="qnty"></param>
        /// <param name="jobID"></param>
        public void PushStock(int partID, decimal qnty, int employeeId)
        {
            // Retrieve the original Part
            var part = context.Part.Find( partID);
            //Create new Inventory Transaction

            Inventory inventory = new Inventory();
            inventory.DateStamp = DateTime.Now;
            inventory.Description = part.ItemDescription;
            inventory.PartId = partID;
            inventory.UnitOfMeasure = part.Uid;
            inventory.EmpId = employeeId;
            inventory.TransActionType = 2;
            inventory.Qnty = qnty;

            context.Entry(inventory).State = EntityState.Added;
            context.Inventory.Add(inventory);
            context.SaveChanges();
        }

      
        /// <summary>
        /// StockLevel
        /// return stock level of a part
        /// in decimals
        /// </summary>
        /// <param name="partNum"></param>
        /// <returns>decimal</returns>
        public decimal StockLevel(int partNum)
        {
           decimal stockLevel = 0.0m;
           stockLevel = context.Inventory.Where(p => p.PartId == partNum).Sum(c => c.Qnty).GetValueOrDefault();
           return stockLevel;
        }
        /// <summary>
        /// Pull Stock
        /// </summary>
        /// <param name="partID"></param>
        /// <param name="qnty"></param>
        /// <param name="jobID"></param>
        public void PullStock(int partID, decimal qnty,int employeeID, int jobID = 106)
        {
            // Pull the part being pulled
            var partBeingPulled = context.Part.Find(partID);

            Inventory pullPartTrans = new Inventory
            {
               
                DateStamp = DateTime.Now,
                PartId = partBeingPulled.PartId,
                EmpId = employeeID,
                Description = partBeingPulled.ItemDescription,
                UnitOfMeasure = partBeingPulled.Uid,
                Qnty = qnty * -1.0m,         
                TransActionType = 3

            };
            context.Inventory.Add(pullPartTrans);
            context.SaveChanges();
        }


        /// <summary>
        /// Adjust the current stock level to a value
        /// </summary>
        /// <param name="partID"></param>
        /// <param name="targetQnty"></param>
        /// <param name="employeeID"></param>
        public void SetStock(int partID, decimal targetQnty, int employeeID)
        {

            decimal currentStock = 0.0m;
            Part part = context.Part.Find(partID);
            if (targetQnty < Decimal.Zero)
            {
                return;
            }
            // Test for any stocktransactions for the part
            if (context.Inventory.Any(p => p.PartId == partID))
            {
                currentStock = context.Inventory.Where(p => p.PartId == partID).Sum(q => q.Qnty.Value);

                // if there more in stock than the target
                if (currentStock > targetQnty)
                {
                    Inventory adjustment = new Inventory
                    {
                        PartId = partID,
                        EmpId = employeeID,
                        TransActionType = 4,
                        UnitOfMeasure = part.Uid.GetValueOrDefault(),
                        DateStamp = DateTime.Now,
                        Qnty = (currentStock * -1.0m)

                    };
                    context.Add(adjustment);
                    context.SaveChanges();
                }
                else if (currentStock < targetQnty)
                {
                    Inventory adjustment = new Inventory
                    {
                        PartId = partID,
                        EmpId = employeeID,
                        TransActionType = 4,
                        UnitOfMeasure = part.Uid.GetValueOrDefault(),
                        DateStamp = DateTime.Now,
                        Qnty = (targetQnty - currentStock)

                    };
                    context.Add(adjustment);
                    context.SaveChanges();
                }
                else if (currentStock == targetQnty)
                {
                    return;
                }

            }
            else   //No Parts have ever been recieved, push a new transaction to start
            {
                Inventory adjustment = new Inventory
                {
                    PartId = partID,
                    EmpId = employeeID,
                    TransActionType = 4,
                    UnitOfMeasure = part.Uid.GetValueOrDefault(),
                    DateStamp = DateTime.Now,
                    Qnty = (targetQnty)

                };
                context.Add(adjustment);
                context.SaveChanges();
            }
        }
       
    }
}
