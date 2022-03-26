using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimDepotMapping
    {
        public int Id { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string TownName { get; set; }
        public string ParentCode { get; set; }
        public string Region { get; set; }
        public string DepotCode { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CompanyCode { get; set; }
    }
}
