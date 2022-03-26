using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ForecastOpsmaster
    {
        public ForecastOpsmaster()
        {
            ForecastOpsdetails = new HashSet<ForecastOpsdetail>();
        }

        public int Id { get; set; }
        public int EntryYear { get; set; }
        public int EntryMonth { get; set; }
        public int ScenarioId { get; set; }
        public string Description { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<ForecastOpsdetail> ForecastOpsdetails { get; set; }
    }
}
