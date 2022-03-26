using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class UnibdClaim
    {
        public int Id { get; set; }
        public int? ClaimMasterId { get; set; }
        public string ClaimNo { get; set; }
        public DateTime? ClaimDate { get; set; }
        public int? ClaimMonth { get; set; }
        public int? ClaimTypeId { get; set; }
        public int? ClaimCategoryId { get; set; }
        public decimal? ClaimAmount { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string DepotCode { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string TownName { get; set; }
        public string ErrorMessage { get; set; }
        public string ClaimType { get; set; }
        public string Abnumbers { get; set; }
        public DateTime? SettledDate { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? StatusId { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public DateTime? TmapproveDate { get; set; }
        public DateTime? CdapproveDate { get; set; }
        public string UpdateUserName { get; set; }
    }
}
