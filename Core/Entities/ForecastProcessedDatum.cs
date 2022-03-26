using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ForecastProcessedDatum
    {
        public int ProcessYear { get; set; }
        public int ScenarioId { get; set; }
        public int MeasureId { get; set; }
        public string MeasureCode { get; set; }
        public string MeasureDescription { get; set; }
        public string Ph9code { get; set; }
        public double January { get; set; }
        public double February { get; set; }
        public double March { get; set; }
        public double April { get; set; }
        public double May { get; set; }
        public double June { get; set; }
        public double July { get; set; }
        public double August { get; set; }
        public double September { get; set; }
        public double October { get; set; }
        public double November { get; set; }
        public double December { get; set; }
    }
}
