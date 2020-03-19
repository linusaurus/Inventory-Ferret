using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;
using DataLayer.Models;

namespace Weaselware.InventoryFerret.Services
{
    public class OrdersBizService
    {
        private readonly BadgerDataModel _context;
        
        public OrdersBizService(BadgerDataModel context)
        {
            _context = context;
        }
        
        public static void CreateOrUpdateOrder(OrderDetailDto orderDTO)
        {

        }
    }
}
