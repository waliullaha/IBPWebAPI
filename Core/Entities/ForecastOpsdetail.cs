using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ForecastOpsdetail
    {
        public ForecastOpsdetail()
        {
            ForecastOpsbrands = new HashSet<ForecastOpsbrand>();
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public int? Abid { get; set; }
        public string Abnumber { get; set; }
        public string RefNo { get; set; }
        public int ActivityTypeId { get; set; }
        public string ActivityName { get; set; }
        public string BudgetSubHead { get; set; }
        public decimal Opsamount { get; set; }
        public decimal Abamount { get; set; }
        public decimal ActualAmount { get; set; }
        public decimal Ytdamount { get; set; }
        public int StartMonth { get; set; }
        public int EndMonth { get; set; }
        public decimal January { get; set; }
        public decimal February { get; set; }
        public decimal March { get; set; }
        public decimal April { get; set; }
        public decimal May { get; set; }
        public decimal June { get; set; }
        public decimal July { get; set; }
        public decimal August { get; set; }
        public decimal September { get; set; }
        public decimal October { get; set; }
        public decimal November { get; set; }
        public decimal December { get; set; }
        public int SelectedRatio { get; set; }

        public virtual ForecastOpsmaster Parent { get; set; }
        public virtual ICollection<ForecastOpsbrand> ForecastOpsbrands { get; set; }
    }
}
