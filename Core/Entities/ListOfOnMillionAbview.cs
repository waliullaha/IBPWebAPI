using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ListOfOnMillionAbview
    {
        public string StartDateFormatted { get; set; }
        public string EndDateFormatted { get; set; }
        public string Fdconsult { get; set; }
        public string Send { get; set; }
        public string Deleted { get; set; }
        public string Abnumber { get; set; }
        public string Abdescription { get; set; }
        public DateTime ActivityStartDate { get; set; }
        public DateTime ActivityEndDate { get; set; }
        public bool IsFdconsult { get; set; }
        public bool IsSend { get; set; }
        public bool IsDeleted { get; set; }
        public string Initiator { get; set; }
        public decimal Abamount { get; set; }
    }
}
