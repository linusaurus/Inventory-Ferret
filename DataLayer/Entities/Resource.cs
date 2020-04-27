using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class Resource
    {
        public Guid ResourceGuid { get; set; }
        public string ResourceDescription { get; set; }
        public string Createdby { get; set; }
        public int CurrentVersion { get; set; }


    }


    public class ResourceVersion
    { 
        public int ResourceVersionID { get; set; }
        public int ResourceGuid { get; set; }
        public int RVersion { get; set; }
        public string VersionComment { get; set; }
        public Byte[] Resource { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModDate { get; set; }
    
    }

}
