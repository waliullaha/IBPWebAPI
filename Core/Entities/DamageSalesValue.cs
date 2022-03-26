using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class DamageSalesValue
    {
        public int ClaimMasterId { get; set; }
        public string DistributorCode { get; set; }
        public decimal ClaimAmount { get; set; }
        public int ClaimMonth { get; set; }
        public decimal? Cumulative { get; set; }
        public decimal? SalesValue { get; set; }
        public decimal? RunningPercentage { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonDescription { get; set; }
    }
}
