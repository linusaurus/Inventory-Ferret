using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;
using DataLayer.Entities;

namespace DataLayer.Models
{
    public class OrderDetailDto : INotifyPropertyChanged
    {
        private decimal tax;
        private decimal shippingCost;
        private bool taxable;

        public event PropertyChangedEventHandler PropertyChanged;

        [Key]
        public int PurchaseOrderID { get; set; }
        public int JobID { get; set; }
        public string JobName { get; set; }
        public string JobCostName { get; set; }
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }    
        public string SupplierPhone { get; set; } 
        public string SupplierFax { get; set; }
        public string Purchaser { get; set; }
        public string OrderDate { get; set; }
        public DateTime ExpectedDate { get; set; }
        public decimal OrderTotal { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierCity { get; set; }
        public string SupplierState { get; set; }
        public string SupplierZip { get; set; }
        // ShipID --
        public int ShipID { get; set; }


        // Taxable--
        public bool Taxable
        {
            get {return taxable; }
            set {
                
                taxable = value;
                OnPropertyChange();
            }
        
        }

        // ShippingCost
        public decimal ShippingCost
        {
            get {return shippingCost; }
            set
            {
                shippingCost = value;
                OnPropertyChange();
            }
        }
        // Tax
        public decimal Tax
        {
            get {return tax; }
            set
            {
                tax = value;
                OnPropertyChange();
            } 
        
        }

        public decimal SubTotal { get; set; }
 
        public ICollection<PurchaseLineItem> LineItems { get; set; } = new HashSet<PurchaseLineItem>();

  
        protected void OnPropertyChange([CallerMemberName] string name=null)
        {
          
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
