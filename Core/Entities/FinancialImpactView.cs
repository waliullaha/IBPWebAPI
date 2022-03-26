using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class FinancialImpactView
    {
        public int Id { get; set; }
        public string Skus { get; set; }
        public decimal? ActualRsp { get; set; }
        public decimal? ActualGm { get; set; }
        public decimal? ActualTm { get; set; }
        public decimal? ForecastRsp { get; set; }
        public decimal? ForecastGm { get; set; }
        public decimal? ForecastTm { get; set; }
        public decimal? CompetitorRsp { get; set; }
        public decimal? CompetitorTm { get; set; }
    }
}
