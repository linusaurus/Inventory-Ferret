using System.Collections.Generic;
//using BadgerData;
using DataLayer.Entities;
using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface IInventoryService {
        void Dispose();
        bool Exist(int stockTransActionID);
        Inventory FindByLineItem(int lineID);
        List<InventoryListDto> GetInventoryByPartID(int partID);
        List<Inventory> GetOrderRecieptItems(int orderRecieptID);
        List<Inventory> GetSupplierInventory(Supplier supplier);
        List<Inventory> GetSupplierInventory(Supplier supplier, string itemName);
        List<Inventory> GetJobInventory(Job job);
        void PushStock(int partID, decimal qnty,int jobID=106 );
        void PullStock(int partID, decimal qnty,int employeeID,int  jobID = 106);
        void SetStock(int partID, decimal qnty, int employeeID);
        void InsertOrUpdate(Inventory inventory);
        decimal StockLevel(int partNum);
        void Save();
    }
}