using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimMtsecondarySale
    {
        public int Id { get; set; }
        public int SalesMonth { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string OutletCode { get; set; }
        public string OutletName { get; set; }
        public string CategoryCode { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public decimal SalesVolume { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal TradePrice { get; set; }
        public decimal RetailValue { get; set; }
        public decimal TradeValue { get; set; }
    }
}
