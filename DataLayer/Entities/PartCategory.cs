using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class PartCategory
    {
       
        public int PartCategoryID { get; set; }
        
        public string PartCategoryName { get; set; }

        public List<PartTypes> PartTypes { get; set; } = new List<PartTypes>();
    }
}
