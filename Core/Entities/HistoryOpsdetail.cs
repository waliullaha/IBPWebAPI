using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class HistoryOpsdetail
    {
        public HistoryOpsdetail()
        {
            HistoryOpsbrands = new HashSet<HistoryOpsbrand>();
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public int? Abid { get; set; }
        public string RefNo { get; set; }
        public int ActivityTypeId { get; set; }
        public string ActivityName { get; set; }
        public int ScenarioId { get; set; }
        public string BudgetSubHead { get; set; }
        public decimal Amount { get; set; }
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

        public virtual ICollection<HistoryOpsbrand> HistoryOpsbrands { get; set; }
    }
}
