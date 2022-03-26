using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimAllocationRule
    {
        public int Id { get; set; }
        public int MonthYear { get; set; }
        public int ClaimTypeId { get; set; }
        public string DistributorCode { get; set; }
        public decimal Target { get; set; }
        public decimal Percentage { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int CompanyId { get; set; }

        public virtual ValueList ClaimType { get; set; }
    }
}
