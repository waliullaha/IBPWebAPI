using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClosingIomasterView
    {
        public int Id { get; set; }
        public int? Ioid { get; set; }
        public int ClosingMonth { get; set; }
        public int ClosingYear { get; set; }
        public string Ab { get; set; }
        public string Io { get; set; }
        public string Abdescription { get; set; }
        public string Initiator { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public decimal Ioamount { get; set; }
        public decimal ActualAmount { get; set; }
        public decimal? Ytdcharge { get; set; }
        public decimal? ChargeBalance { get; set; }
        public decimal? ProvBalance { get; set; }
        public string Iorule { get; set; }
        public string ActivityType { get; set; }
    }
}
