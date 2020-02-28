using AutoMapper;
using AutoMapper.Collection;
using AutoMapper.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weaselware.InventoryFerret.Wrapper;
using DataLayer.Entities;
using DataLayer.Models;
using AutoMapper.Configuration;
using Weaselware.InventoryFerret.Profiles;


namespace Weaselware.InventoryFerret
{
    public static class Bootstrap
    {
        public static void  bootstrap()
        {
            var config = new MapperConfiguration(cfg => {

                cfg.AddProfile<OrdersProfile>();
               
               
            });

            IMapper mapper = config.CreateMapper();
            // or
            //IMapper mapper = new Mapper(config);
            //var dest = mapper.Map<Source, Dest>(new Source());

        }
    }
}
