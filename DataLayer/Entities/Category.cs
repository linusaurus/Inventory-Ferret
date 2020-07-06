using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class Category
    {
        public Category()
        {
            PartTypes = new HashSet<PartTypes>();
        }

        public int Categoryid { get; set; }
        public string Category1 { get; set; }
        public int? PartClassId { get; set; }

        public virtual PartClass PartClass { get; set; }
        public virtual ICollection<PartTypes> PartTypes { get; set; }
    }
}
