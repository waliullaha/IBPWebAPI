using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class MonthlyClaimManual
    {
        public string Region { get; set; }
        public string TownName { get; set; }
        public string ClaimGroup { get; set; }
        public string ClaimName { get; set; }
        public string ClaimSpecificName { get; set; }
        public decimal ClaimAmount { get; set; }
        public string ClaimReference { get; set; }
        public string DistributorClaimReference { get; set; }
        public string ReceivedDate { get; set; }
        public decimal SettledAmount { get; set; }
        public string SettledDate { get; set; }
        public decimal DeductedAmount { get; set; }
        public string RejectDate { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public string Department { get; set; }
        public int EntryUserId { get; set; }
        public string EntryDate { get; set; }
    }
}
