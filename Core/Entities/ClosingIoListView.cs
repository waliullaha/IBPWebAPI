using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClosingIoListView
    {
        public int Id { get; set; }
        public string Ionumber { get; set; }
        public string Description { get; set; }
        public string Initiator { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public decimal Ioamount { get; set; }
        public decimal ActualAmount { get; set; }
        public int Ioid { get; set; }
        public int ClosingMonth { get; set; }
        public int ClosingYear { get; set; }
        public string PnLcbt { get; set; }
        public decimal? Jv { get; set; }
        public decimal? Charge { get; set; }
        public decimal? Ytd { get; set; }
        public decimal? ChargeBalance { get; set; }
        public decimal? ProvBalance { get; set; }
    }
}
