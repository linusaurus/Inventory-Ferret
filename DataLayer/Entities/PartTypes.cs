using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class PartTypes
    {
        public int PartTypeID { get; set; }
        public string PartTypeName { get; set; }
        public int PartCategoryID { get; set; }
        public PartCategory PartCategory { get; set; }
       
    }
}
