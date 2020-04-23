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
    public class PartDetailsMappers : IMapper<Part, PartDetailDTO>
    {
        public void Map(Part source, PartDetailDTO destination)
        {
            if (source == null) { return; }
            destination.PartID = source.PartID;
            destination.ItemDescription = source.ItemDescription;
            destination.PartNum = source.PartNum;
            destination.PartTypeID = source.PartTypeId.GetValueOrDefault();
            destination.AddedBy = source.AddedBy;
            destination.DateAdded = source.DateAdded.GetValueOrDefault();
            destination.Location = source.Location;
            destination.ManuId = source.ManuId.GetValueOrDefault();
            destination.ModifiedBy = source.ModifiedBy;
            destination.ModifiedDate = source.ModifiedDate.GetValueOrDefault();
            destination.Sku = source.Sku;

        }
    }
}
