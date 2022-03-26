using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimMtrate
    {
        public int Id { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string KeyAccountCode { get; set; }
        public string KeyAccountName { get; set; }
        public string OutletCode { get; set; }
        public string OutletName { get; set; }
        public int GondolaSerialNo { get; set; }
        public string GondolaPosition { get; set; }
        public int FromMonth { get; set; }
        public int ToMonth { get; set; }
        public bool AgreedMargin { get; set; }
        public decimal AgreedPercentage { get; set; }
        public decimal Rate { get; set; }
        public decimal TotalValue { get; set; }
    }
}
