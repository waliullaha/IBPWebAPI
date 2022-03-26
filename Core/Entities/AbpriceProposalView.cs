using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AbpriceProposalView
    {
        public int Id { get; set; }
        public string Activity { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Skus { get; set; }
        public string ActivityStartDate { get; set; }
        public string Background { get; set; }
        public string Rationale { get; set; }
        public string MarketShare { get; set; }
        public string PriceChangeRisks { get; set; }
    }
}
