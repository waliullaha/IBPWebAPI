using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimDidistributorSkutarget
    {
        public int Id { get; set; }
        public int SalesMonth { get; set; }
        public int SalesYear { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        /// <summary>
        /// get from necleus
        /// </summary>
        public decimal ListPrice { get; set; }
        public decimal Target { get; set; }
        /// <summary>
        /// TargetValue = LP * Target
        /// </summary>
        public decimal TargetValue { get; set; }
    }
}
