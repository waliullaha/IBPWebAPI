using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimBudget
    {
        public int Id { get; set; }
        /// <summary>
        /// ABID
        /// </summary>
        public int ParentId { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public decimal Percentage { get; set; }
        public decimal ApprovedBudget { get; set; }
        public decimal AllocatedBudget { get; set; }

        public virtual Abmaster Parent { get; set; }
    }
}
