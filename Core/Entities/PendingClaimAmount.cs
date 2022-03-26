using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class PendingClaimAmount
    {
        public string DistributorCode { get; set; }
        public string TownName { get; set; }
        public string Region { get; set; }
        public string DistributorName { get; set; }
        public decimal PendingAmount { get; set; }
        public decimal ClosedAmount { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
