using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimCmhopidatum
    {
        public int Id { get; set; }
        public int MonthYear { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public decimal Percentage { get; set; }
    }
}
