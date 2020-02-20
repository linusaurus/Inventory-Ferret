/* *********************************
        Joining table for Part
        and documents
*/
using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class DocumentParts
    {
        public int PartId { get; set; }
        public int DocId { get; set; }

        public  Document Doc { get; set; }
        public  Part Part { get; set; }
    }
}
