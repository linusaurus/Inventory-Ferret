using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
//using BadgerData;
using DataLayer.Entities;
using DataLayer.Interfaces;
using DataLayer.Models;


namespace DataLayer.Services {

    public class OrdersService : IDisposable, IOrdersService {

        private readonly BadgerDataModel context;
        IPartsService _partService;

        public OrdersService(BadgerDataModel Context) {
            
            context = Context;
            _partService = new PartsService(context);
        }

        public OrderDetailDto GetOrderDTO(int orderID)
        {
            var _order = context.PurchaseOrder.Where(p => p.OrderNum == orderID).Select(d => new OrderDetailDto
            {
                PurchaseOrderID = d.OrderNum,
                OrderDate = d.OrderDate.Value,
                OrderTotal = d.OrderTotal.Value,
                ExpectedDate = d.ExpectedDate.Value,
                JobCostName = d.Job.Jobdesc,
                JobName = d.Job.Jobname,
                JobID = d.JobId.Value,
                Purchaser = d.Employee.Firstname + " " + d.Employee.Lastname,
                ShippingCost = d.ShippingCost.HasValue ? d.ShippingCost.Value : Decimal.Zero,
                SubTotal = d.SubTotal.HasValue ? d.SubTotal.Value : Decimal.Zero,
                ShipID= d.ShipId.Value,
                SupplierAddress = d.Supplier.Address1,
                SupplierCity = d.Supplier.City,
                SupplierName = d.Supplier.SupplierName,
                SupplierState = d.Supplier.State,
                SupplierID = d.SupplierId.HasValue ? d.SupplierId.Value : 0,
                SupplierPhone = d.Supplier.Phone,
                SupplierZip = d.Supplier.Zip,
                Tax = d.Tax.HasValue ? d.Tax.Value : Decimal.Zero,
                Taxable = d.SuppressTax.HasValue ? d.SuppressTax.Value : false

            });
            return _order.FirstOrDefault();
        }

        public List<LineItemDto> GetLineItems(int orderID)
        {
            var _lineItems = context.PurchaseLineItem.Where(f => f.PurchaseOrderId == orderID).Select(d => new LineItemDto
            {
                Description = d.Description,
                LineID = d.LineId,
                Quantity = d.Qnty.Value,
                Price = d.UnitCost.Value,
                Extended = d.Extended.Value,
                PartID = d.PartId,
                PurchaseOrderID = d.PurchaseOrderId.Value,
            });
            return _lineItems.ToList();
        }

        public void SaveOrder(OrderDetailDto order)
        {

        }

        public bool Exist(int orderID) {

            bool result = false;
            if (context.PurchaseOrder.Any(c=> c.OrderNum == orderID))
            {
                result = true;
            }

            return result;
        }

        public BindingList<PurchaseLineItem> OrderLineItems(int purchaseOrderID)
        {
            BindingList<PurchaseLineItem> result = new BindingList<PurchaseLineItem>();
          
            return result;
        }

        public PurchaseOrder GetOrderByID(int orderNum) {

            return context.PurchaseOrder
                .Include(path=> path.PurchaseLineItem)
                .Include(j => j.Job)
                .Include(e => e.Employee).Where(c => c.OrderNum == orderNum).FirstOrDefault();
        }

        public List<PurchaseOrder> GetAllOrders() {

            return context.PurchaseOrder.ToList();
        }

        public List<PurchaseOrder> GetSupplierOrders(int supplierID) {

            return context.PurchaseOrder.Where(c => c.SupplierId == supplierID).OrderByDescending(d => d.OrderDate).ToList();
        }

        public List<PurchaseOrder> GetJobOrders(int jobID) {

            return context.PurchaseOrder.Where(c => c.JobId == jobID).ToList();
        }

        public void InsertOrUpdate(PurchaseOrder order) {

            if (order.OrderNum == default(int))
            {
                context.Entry(order).State = EntityState.Added ;
                context.PurchaseOrder.Add(order);
            }
            else
            {
                context.PurchaseOrder.Attach(order);
            }
        }

        public PurchaseOrder NewDefault(int employee, int supplierId, int jobID) {

            PurchaseOrder po = new PurchaseOrder();
            po.EmployeeId = employee;
            po.SupplierId = supplierId;
            po.DateAdded = DateTime.Today;
            po.OrderDate = DateTime.Today;
            po.ExpectedDate = DateTime.Today;
            po.IsBackOrder = false;
            po.JobId = jobID;
            po.Memo = " ";
            po.OrderState = 0;
            po.OrderTotal = 0.00m;
            po.SalesRep = "";
            po.ShipId = 1;
            po.ShippingCost = 0.00m;
            po.SuppressTax = false;
            po.SubTotal = 0.00m;
            po.Recieved = false;
            po.Tax = 0.00m;
            po.OrderFormat = "Standard";
            po.AddedBy = context.Employee.Find(employee).Firstname + " " + context.Employee.Find(employee).Lastname;
            po.OrderState = 1;
            return po;
        }

        public void Delete(int orderID) {

            PurchaseOrder po = context.PurchaseOrder.Where(c => c.OrderNum == orderID).FirstOrDefault();
            context.Entry(po).State = EntityState.Deleted;
            context.PurchaseOrder.Remove(po);

        }
        //Recieve Order --
        public OrderReciept RecievedOrder(PurchaseOrder order, int employeeID) {

            // Build and save OrderReceipt --
            OrderReciept oreciept = new OrderReciept();
            oreciept.OrderNum = order.OrderNum;
            oreciept.EmployeeId = employeeID;
            oreciept.ReceiptDate = DateTime.Now;
            context.OrderReciept.Add(oreciept);
            context.SaveChanges();
            List<ClaimItem> claimItems = new List<ClaimItem>();

            foreach (PurchaseLineItem item in order.PurchaseLineItem)
            {

                Inventory inv = new Inventory();
                inv.DateStamp = DateTime.Now;
                inv.Description = item.Description.ToString().TrimEnd();
                inv.JobId = order.JobId;
                inv.LineId = item.LineId;
                inv.Location = string.Empty;
                inv.Note = item.Note;
                inv.OrderReceiptID = oreciept.OrderReceiptId;
                inv.UnitOfMeasure = item.Uom ?? 1;
                inv.Qnty = item.Qnty ?? 0;      
                item.Recieved = true;
                item.OrderReceiptId = oreciept.OrderReceiptId;
                inv.PartId = item.PartId ?? null;
                if (!(item.Description.Length == 0) && !(item.Qnty == default(decimal)) )
                {
                    context.Entry(inv).State = EntityState.Added;
                    context.Inventory.Add(inv);
                    context.Entry(item).State = EntityState.Modified;
                    if (item.Rejected == true)
                    {
                        var c = new ClaimItem
                        {
                            LineId = item.LineId,
                            Description = item.Description,
                            Bcode = item.Bcode,
                            PartId = item.PartId
                        };
                        claimItems.Add(c);
                    }

                }
               
               
            }
            order.Recieved = true;
            order.RecievedDate = DateTime.Today;
            if (claimItems.Count > 0)
            {
                //ClaimService claimService = new ClaimService(context);
                //var newClaim = claimService.NewClaim(order.OrderNum, Globals.CurrentLoggedUserID);

                //foreach (ClaimItem clm in claimItems)
                //{
                //    newClaim.ClaimItem.Add(clm);
                //}
                context.SaveChanges();
            }

            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                string err = ex.InnerException.ToString();
                Console.Write(err);
                throw;
            }
            return oreciept;
        
        }

        public void Save() {

            context.SaveChanges();
        }

        public void Dispose() {

            context.Dispose();
        }

        public List<SupplierOrderDTO> GetSupplierOrdersDTO(int SupplierID)
        {
            List<SupplierOrderDTO> result = new List<SupplierOrderDTO>();
            SupplierOrderDTO dto;

            using (BadgerDataModel ctx = new BadgerDataModel())
            {
            // Get all the Suppliers Orders --
            var pOrders = ctx.PurchaseOrder.Where(p => p.SupplierId == SupplierID).ToList();

                foreach (var P in pOrders)
                {
                dto = new SupplierOrderDTO();
                dto.PurchaserName = P.Employee.Lastname;
                    if(P.Job != null)
                    { dto.JobName = P.Job.Jobname; }
               
                dto.OrderDate = P.OrderDate;
                dto.OrderNum = P.OrderNum;
                dto.Received = P.Recieved;
                dto.SupplierName = P.Supplier.SupplierName;
                dto.ReceiveStatus = "none";
                result.Add(dto);

                }
             }
            
            return result;           
        }

        public List<SupplierLineItemDto> GetSupplierLineItems(int supplierID)
        {
            string id = supplierID.ToString();
            
            string sql = @"select Description,PartID,LineID,Qnty,UnitCost,PurchaseOrderID FROM PurchaseLineItem " +
                          " WHERE OrderReceiptID IN(SELECT OrderReceiptID FROM OrderReciept WHERE OrderNum IN " +
                          "(SELECT OrderNum FROM PurchaseOrder WHERE SupplierID = 2244))"; 
                        
            ///TODO pass a parameter to the sql
            var  result = context.PurchaseLineItem.FromSqlRaw(sql).Select( d => new SupplierLineItemDto 
            {
                Description = d.Description,
                LineID =  d.LineId,
                PartID =  d.PartId.GetValueOrDefault(),
                UnitCost =d.UnitCost.GetValueOrDefault(),
                OrderNum = d.PurchaseOrderId.GetValueOrDefault()
            })
                .ToList();

            return result;
        }

        public List<UnitOfMeasure> GetUnits()
        {
          return context.UnitOfMeasure.AsNoTracking().ToList() ;
        }
        /// <summary>
        /// TODO this need to be much more expanded and use a composite Order DTO
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public PurchaseOrder Add(PurchaseOrder order)
        {
            context.PurchaseOrder.Add(order);
            context.SaveChanges();
            return order;
        }
    }
}
