using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    public class TaxRate
    {
        public string State { get; set; }
        [Key]
        public int ZipCode { get; set; }

        public string TaxRegionName { get; set; }
        public double StateRate {get;set;}
        public double EstimatedCombinedRate { get; set; }
        public double EstimatedCountyRate { get; set; }
        public double EstimatedCityRate { get; set; }
        public double EstimatedSpecialRate { get; set; }
        public string RiskLevel { get; set; }

    }
}
