using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimCmhopisetup
    {
        public int Id { get; set; }
        public decimal MinPercentage { get; set; }
        public decimal MaxPercentage { get; set; }
        public decimal Amount { get; set; }
    }
}
