using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClosingIoallocationRuleView
    {
        public int Ioid { get; set; }
        public string Ionumber { get; set; }
        public string Abdescription { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Ph9code { get; set; }
        public decimal AllocationRule { get; set; }
    }
}
