using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimBudgetView
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public decimal Percentage { get; set; }
        public decimal ApprovedBudget { get; set; }
        public decimal AllocatedBudget { get; set; }
        public string ApprovedBudgetMillionFormat { get; set; }
        public string AllocatedBudgetMillionFormat { get; set; }
    }
}
