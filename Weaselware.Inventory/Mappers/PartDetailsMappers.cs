using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;
using DataLayer.Models;
using Boxed.Mapping;
using System.Security.Cryptography;

namespace Weaselware.InventoryFerret.Mappers
{
    public class PartDetailsMappers : IMapper<Part, PartDetailDTO>
    {

        private readonly IMapper<Resource, ResourceDto> resourceMapper = new PartResourceMapper();
       

        public void Map(Part source, PartDetailDTO destination)
        {
            if (source == null) { return; }
            destination.PartID = source.PartID;
            destination.ItemDescription = source.ItemDescription;
            destination.PartNum = source.PartNum;
            destination.PartTypeID = source.PartTypeId.GetValueOrDefault();
            destination.Location = source.Location;
            destination.ManuId = source.ManuId.GetValueOrDefault();
            destination.MarkUp = source.MarkUp.GetValueOrDefault();
            destination.AddedBy = source.AddedBy;
            destination.DateAdded = source.DateAdded.GetValueOrDefault();
            destination.ModifiedBy = source.ModifiedBy;
            destination.ModifiedDate = source.ModifiedDate.GetValueOrDefault();
            destination.Sku = source.Sku;

            destination.Resources = resourceMapper.MapList(source.GetResource);
        }
    }

    public class PartResourceMapper : IMapper<Resource, ResourceDto>
    {
        private readonly IMapper<ResourceVersion, ResourceVersionDto> resourceVersionMapper = new ResourceVersionMapper();
        public void Map(Resource source, ResourceDto destination)
        {
            destination.Createdby = source.Createdby;
            destination.CurrentVersion = source.CurrentVersion.GetValueOrDefault();
            destination.ResourceDescription = source.ResourceDescription;
            destination.ResourceID = source.ResourceID;
            destination.Versions = resourceVersionMapper.MapList(source.ResourceVersions);
        }
    }
    public class ResourceVersionMapper : IMapper<ResourceVersion, ResourceVersionDto>
    {
        public void Map(ResourceVersion source, ResourceVersionDto destination)
        {
            destination.ResourceID = source.ResourceID;
            destination.ResourceVersionID = source.ResourceVersionID;
            destination.RVersion = source.RVersion;
            destination.VersionComment = source.VersionComment;
            destination.ModDate = source.ModDate;
            destination.ModifiedBy = source.ModifiedBy;


        }
    }
}
