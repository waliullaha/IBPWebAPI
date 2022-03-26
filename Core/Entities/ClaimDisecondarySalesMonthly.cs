using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimDisecondarySalesMonthly
    {
        public int Id { get; set; }
        public int SalesMonth { get; set; }
        public int SalesYear { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public decimal ListPrice { get; set; }
        public decimal SalesVolume { get; set; }
        /// <summary>
        /// SalesValue = LP * SalesVolume
        /// </summary>
        public decimal SalesValue { get; set; }
    }
}
