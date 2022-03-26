using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class LateClaimUploadDistributorSetUp
    {
        public int Id { get; set; }
        public string Town { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public int DaysAllowedForDistributor { get; set; }
        public string Remarks { get; set; }
        public DateTime ExceptionApprovedOn { get; set; }
        public DateTime AllowedToDate { get; set; }
        public DateTime AllowedDate { get; set; }
    }
}
