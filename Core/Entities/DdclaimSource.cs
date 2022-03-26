using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class DdclaimSource
    {
        public string Abnumber { get; set; }
        public string ClaimNo { get; set; }
        public string DistributorCode { get; set; }
        public string DocumentDate { get; set; }
        public string ProcessedDate { get; set; }
        public string PostingKey { get; set; }
        public string EmptyAbnumber { get; set; }
        public decimal? TotalClaimAmount { get; set; }
    }
}
