using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimBudgetNoAb
    {
        public int Id { get; set; }
        public int ClaimTypeId { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public int Year { get; set; }
        public decimal ClaimBudget { get; set; }
        public decimal AmendAmount { get; set; }
        public DateTime ActivityStartDate { get; set; }
        public DateTime ActivityEndDate { get; set; }
        public DateTime CutOffDate { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ValueList ClaimType { get; set; }
    }
}
