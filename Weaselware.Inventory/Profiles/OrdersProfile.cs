using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;
using DataLayer.Models;
using Weaselware.InventoryFerret.Wrapper;

namespace Weaselware.InventoryFerret.Profiles
{
    
    
        public class OrdersProfile : Profile
        {
            public OrdersProfile()
            {
                CreateMap<PurchaseLineItem, PurchaseLineItemWrapper>();
               // CreateMap<Models.CourseForCreationDto, Entities.Course>();
            }
        }
    
}
