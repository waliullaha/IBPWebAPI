using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class JccalendarView
    {
        public int Id { get; set; }
        public string Jccode { get; set; }
        public int Jcyear { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Jctext { get; set; }
        public string StartDateFormatted { get; set; }
        public string EndDateFormatted { get; set; }
        public string JcstartDate { get; set; }
        public string JcendDate { get; set; }
        public int? FromMonth { get; set; }
        public int? ToMonth { get; set; }
        public string StartMonthYearText { get; set; }
        public string EndMonthYearText { get; set; }
    }
}
