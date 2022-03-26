using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimMtagreedMargin
    {
        public int Id { get; set; }
        public DateTime AgreedMonth { get; set; }
        public string KeyAccountCode { get; set; }
        public string KeyAccountName { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public decimal AgreedPercentage { get; set; }
        public decimal TpsalesValue { get; set; }
        public decimal MrpsalesValue { get; set; }
        public decimal MarginValue { get; set; }
        public decimal MarginPercentage { get; set; }
        public decimal IncrementalMargin { get; set; }
    }
}
