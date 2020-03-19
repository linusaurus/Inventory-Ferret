using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;
using DataLayer.Models;
using Boxed.Mapping;

namespace Weaselware.InventoryFerret.Mappers
{
    public class PurchaseOrderMapper : IMapper<PurchaseOrder, OrderDetailDto>
    {
        private readonly IMapper<PurchaseLineItem, LineItemDto> lineMapper = new LineItemMapper()  ;
        

        public void Map(PurchaseOrder source, OrderDetailDto destination)
        {
            destination.ExpectedDate = source.ExpectedDate ?? DateTime.Today.AddDays(1.0);
            destination.OrderDate = source.OrderDate.Value.ToShortDateString();
            destination.JobCostName = source.Job.Jobdesc;
            destination.JobID = source.JobId.GetValueOrDefault();
            destination.JobName = source.Job.Jobname;
            destination.EmployeeID = source.EmployeeId.GetValueOrDefault();
            destination.OrderTotal = source.OrderTotal.GetValueOrDefault();
            destination.PurchaseOrderID = source.OrderNum;
            destination.Purchaser = source.Employee.Firstname + " " + source.Employee.Lastname;
            destination.ShipID = source.ShipId.GetValueOrDefault();
            destination.ShippingCost = source.ShippingCost.GetValueOrDefault();
            destination.SubTotal = source.SubTotal.GetValueOrDefault();
            destination.SupplierName = source.Supplier.SupplierName;
            destination.SupplierAddress = source.Supplier.Address1 ?? "";
            destination.SupplierCity = source.Supplier.City;
            destination.SupplierState = source.Supplier.State;
            destination.SupplierZip = source.Supplier.Zip;
            destination.SalesRep = source.SalesRep;
            destination.Tax = source.Tax.GetValueOrDefault();
            destination.Taxable = source.SuppressTax.GetValueOrDefault();
            destination.SupplierID = source.SupplierId.GetValueOrDefault();
            destination.SupplierPhone = source.Supplier.Phone;
            destination.SupplierFax = source.Supplier.Fax;
            destination.OrderTotal = source.OrderTotal.GetValueOrDefault();
            destination.Memo = source.Memo;
            destination.LineItems = lineMapper.MapList(source.PurchaseLineItem);
        }
    }

    public class LineItemMapper : IMapper<PurchaseLineItem, LineItemDto>
    {
        public void Map(PurchaseLineItem source, LineItemDto destination)
        {
            destination.LineID = source.LineID;
            destination.PartID = source.PartID.GetValueOrDefault();
            destination.Price = source.UnitCost.GetValueOrDefault();
            destination.PurchaseOrderID = source.PurchaseOrderId.GetValueOrDefault();
            destination.Description = source.Description;
            destination.Quantity = source.Qnty.GetValueOrDefault();
            destination.UiD = source.Uom.GetValueOrDefault();
            destination.Extended = source.Extended.GetValueOrDefault();
           
        }
    }
}
