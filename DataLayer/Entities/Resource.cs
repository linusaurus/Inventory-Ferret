using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class Resource
    {
        public int ResourceID { get; set; }
        public string ResourceDescription { get; set; }
        public string Createdby { get; set; }
        public int CurrentVersion { get; set; }

        // relationship child collection ----------------
        public List<ResourceVersion> Versions { get; set; } = new List<ResourceVersion>();

    }


    public class ResourceVersion
    { 
        public int ResourceVersionID { get; set; }
        public int ResourceID { get; set; }
        public int RVersion { get; set; }
        public string VersionComment { get; set; }
        public Byte[] Resource { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModDate { get; set; }

        // relationships ------------------------------

        public Resource GetResource { get; set; }
    }

}
