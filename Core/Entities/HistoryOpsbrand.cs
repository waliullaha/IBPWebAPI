using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class HistoryOpsbrand
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int Opsid { get; set; }
        public string Ph5code { get; set; }
        public string Ph5name { get; set; }
        public decimal Gsv { get; set; }
        public decimal Gsvratio { get; set; }
        public decimal AllocationGsv { get; set; }
        public decimal AbsoluteRatio { get; set; }
        public decimal AllocationAbsolute { get; set; }

        public virtual HistoryOpsdetail Parent { get; set; }
    }
}
