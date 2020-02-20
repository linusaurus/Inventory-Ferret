using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class Attachment
    {
        public int AttachmentId { get; set; }
        public string AttachmentDescription { get; set; }
        public int? OrderNum { get; set; }
        public string Ext { get; set; }
        public string Src { get; set; }
        public byte[] Filesource { get; set; }

        public virtual PurchaseOrder OrderNumNavigation { get; set; }
    }
}
