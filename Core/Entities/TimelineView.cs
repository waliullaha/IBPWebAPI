using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class TimelineView
    {
        public int Id { get; set; }
        public string Skus { get; set; }
        public string EffectiveDate { get; set; }
        public string LastPriceChangeDate { get; set; }
    }
}
