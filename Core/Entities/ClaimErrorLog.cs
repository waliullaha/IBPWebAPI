using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimErrorLog
    {
        public int Id { get; set; }
        public int ClaimMasterId { get; set; }
        public string ClaimNo { get; set; }
        public int ClaimTypeId { get; set; }
        public int ClaimMonth { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public decimal ClaimAmount { get; set; }
        public string ErrorMessage { get; set; }
        public string ProcessUserId { get; set; }
        public string ProcessUserName { get; set; }
        public DateTime? ClaimDate { get; set; }
        public DateTime? ErrorProcessedDate { get; set; }
    }
}
