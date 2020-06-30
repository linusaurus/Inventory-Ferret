using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class Resource
    {
        public int ResourceID { get; set; }

        public int? PartID { get; set; }
        public string ResourceDescription { get; set; }
        public string Createdby { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CurrentVersion { get; set; }

        public DateTime? RevisionDate { get; set; }

        public byte[] Data { get; set; }

        public string FileSize { get; set; }

        public Part Part { get; set; }


    }


  
}
