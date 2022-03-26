using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AhsAllClaimMaster
    {
        public int Id { get; set; }
        public int ClaimTypeId { get; set; }
        public string ClaimType { get; set; }
        /// <summary>
        /// For Perfect Store Damage
        /// </summary>
        public DateTime ClaimDate { get; set; }
        public string DepotCode { get; set; }
        public string DistributorCode { get; set; }
        public string ClaimNo { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool IsCdmapprove { get; set; }
        public DateTime? CdmapproveDate { get; set; }
        public int? CdmuserId { get; set; }
        public bool IsCddapprove { get; set; }
        public DateTime? CddapproveDate { get; set; }
        public int? CdduserId { get; set; }
        public bool IsTmmapprove { get; set; }
        public DateTime? TmmapproveDate { get; set; }
        public int? TmmuserId { get; set; }
        public string ClaimStatus { get; set; }
        public decimal? PercentageOfSecondarySales { get; set; }
        public int GiftMonth { get; set; }
    }
}
