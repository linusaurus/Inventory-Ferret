using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class PartTypes
    {
   

        public int PartTypeID { get; set; }
        public string PartTypeName { get; set; }
        public int? Categoryid { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Part> Part { get; set; } = new List<Part>();
    }
}
