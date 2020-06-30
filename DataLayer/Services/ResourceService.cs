using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Entities;
using DataLayer.Models;
using System.Linq;

namespace DataLayer.Services
{
    public class ResourceService 
    {

        private readonly BadgerDataModel ctx;

        // Constructor --------------------------------
        public ResourceService(BadgerDataModel Context)
        { ctx = Context;}

        public Resource Find(int resourceID)
        {
            return ctx.Resource.Find(resourceID);
        }


        public Resource PushVersion(Resource pushResource,Byte[] newfile,string comment, string user)
        {            
            var resource = ctx.Resource.FirstOrDefault(o => o.ResourceID == pushResource.ResourceID);

            // Create a new Resource Version Object and populate it
            ResourceVersion version = new ResourceVersion();
            version.ModDate = DateTime.Today;
            version.ModifiedBy = user;
            version.ResourceID = resource.ResourceID;
            version.RVersion = resource.CurrentVersion.GetValueOrDefault();
            version.VersionComment = comment;
            version.Resource = newfile;
            ctx.ResourceVersion.Add(version);

            resource.CurrentVersion = version.RVersion;

            ctx.SaveChanges();

            return resource;
            
        }
    }
}
