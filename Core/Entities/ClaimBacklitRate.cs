using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimBacklitRate
    {
        public int Id { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public decimal Rate { get; set; }
    }
}
