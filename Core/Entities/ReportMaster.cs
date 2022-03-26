using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ReportMaster
    {
        public ReportMaster()
        {
            ReportDetails = new HashSet<ReportDetail>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }
        public bool? IsActive { get; set; }
        public bool Mtvalue { get; set; }
        public bool IsUpguvg { get; set; }
        public int? EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual ICollection<ReportDetail> ReportDetails { get; set; }
    }
}
