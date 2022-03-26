using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class SecondarySale
    {
        public int Id { get; set; }
        public int SalesMonth { get; set; }
        public int SalesYear { get; set; }
        public string DistributorCode { get; set; }
        public decimal SalesValue { get; set; }
        public decimal SalesVolume { get; set; }
    }
}
