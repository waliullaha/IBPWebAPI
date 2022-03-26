using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimManualMaster
    {
        public int Id { get; set; }
        public string Region { get; set; }
        public string TownName { get; set; }
        public string ClaimGroup { get; set; }
        public string ClaimName { get; set; }
        public string ClaimSpecificName { get; set; }
        public decimal ClaimAmount { get; set; }
        public string ClaimReference { get; set; }
        public string DistributorClaimReference { get; set; }
        public string DistributorCode { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public decimal SettledAmount { get; set; }
        public DateTime? SettledDate { get; set; }
        public decimal DeductedAmount { get; set; }
        public DateTime? RejectDate { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public string Department { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
