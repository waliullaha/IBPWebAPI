using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimDidistributorPscomplaince
    {
        public int Id { get; set; }
        public int SalesMonth { get; set; }
        public int SalesYear { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public decimal Complaince { get; set; }
    }
}
