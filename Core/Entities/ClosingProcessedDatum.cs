using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClosingProcessedDatum
    {
        public int ProcessYear { get; set; }
        public int Ioid { get; set; }
        public int MeasureId { get; set; }
        public string MeasureCode { get; set; }
        public string MeasureDescription { get; set; }
        public string Ph9code { get; set; }
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
    }
}
