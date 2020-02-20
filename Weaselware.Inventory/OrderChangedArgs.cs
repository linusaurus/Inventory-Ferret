using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;

namespace Weaselware.InventoryFerret
{
    public class OrderChangedArgs : EventArgs
    {
        public PurchaseOrder Order { get; set; }
    }
}
