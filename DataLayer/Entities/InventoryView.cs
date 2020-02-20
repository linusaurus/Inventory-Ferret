﻿using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class InventoryView
    {
        public int? PartId { get; set; }
        public decimal? StockLevel { get; set; }
        public string Description { get; set; }
    }
}
