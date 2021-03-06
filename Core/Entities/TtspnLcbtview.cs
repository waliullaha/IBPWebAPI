using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class TtspnLcbtview
    {
        public int Ioid { get; set; }
        public string PnLcbt { get; set; }
        public int ClosingMonth { get; set; }
        public int ClosingYear { get; set; }
        public bool IsJvcreate { get; set; }
        public DateTime? JvcreateDate { get; set; }
        public string Ionumber { get; set; }
        public string Abnumber { get; set; }
        public string Description { get; set; }
        public string Initiator { get; set; }
        public string ActivityStartDate { get; set; }
        public string ActivityEndDate { get; set; }
        public decimal Ioamount { get; set; }
        public decimal ActualAmount { get; set; }
        public int ActivityTypeId { get; set; }
        public decimal? Jv { get; set; }
    }
}
