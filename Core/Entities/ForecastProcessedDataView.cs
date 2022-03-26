using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ForecastProcessedDataView
    {
        public int ProcessYear { get; set; }
        public int ScenarioId { get; set; }
        public int MeasureId { get; set; }
        public string MeasureCode { get; set; }
        public string MeasureDescription { get; set; }
        public int? LocationId { get; set; }
        public string LocationCode { get; set; }
        public double January { get; set; }
        public double JanuaryYtd { get; set; }
        public double February { get; set; }
        public double? FebruaryYtd { get; set; }
        public double March { get; set; }
        public double? MarchYtd { get; set; }
        public double? Q1total { get; set; }
        public double? Q1totalYtd { get; set; }
        public double April { get; set; }
        public double? AprilYtd { get; set; }
        public double May { get; set; }
        public double? MayYtd { get; set; }
        public double June { get; set; }
        public double? JuneYtd { get; set; }
        public double? Q2total { get; set; }
        public double? Q2totalYtd { get; set; }
        public double? FirstHalf { get; set; }
        public double? FirstHalfYtd { get; set; }
        public double July { get; set; }
        public double? JulyYtd { get; set; }
        public double August { get; set; }
        public double? AugustYtd { get; set; }
        public double September { get; set; }
        public double? SeptemberYtd { get; set; }
        public double? Q3total { get; set; }
        public double? Q3totalYtd { get; set; }
        public double October { get; set; }
        public double? OctoberYtd { get; set; }
        public double November { get; set; }
        public double? NovemberYtd { get; set; }
        public double December { get; set; }
        public double? DecemberYtd { get; set; }
        public double? Q4total { get; set; }
        public double? Q4totalYtd { get; set; }
        public double? SecondHalf { get; set; }
        public double? SecondHalfYtd { get; set; }
        public double? YearlyTotal { get; set; }
        public double? YearlyTotalYtd { get; set; }
        public string Ph0code { get; set; }
        public string Ph0name { get; set; }
        public string Ph1code { get; set; }
        public string Ph1name { get; set; }
        public string Ph2code { get; set; }
        public string Ph2name { get; set; }
        public string Ph3code { get; set; }
        public string Ph3name { get; set; }
        public string Ph4code { get; set; }
        public string Ph4name { get; set; }
        public string Ph5code { get; set; }
        public string Ph5name { get; set; }
        public string Ph6code { get; set; }
        public string Ph6name { get; set; }
        public string Ph7code { get; set; }
        public string Ph7name { get; set; }
        public string Ph8code { get; set; }
        public string Ph8name { get; set; }
        public string Ph9code { get; set; }
        public string Ph9name { get; set; }
    }
}
