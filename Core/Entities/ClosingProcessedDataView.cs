using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClosingProcessedDataView
    {
        public int ProcessYear { get; set; }
        public int MeasureId { get; set; }
        public string MeasureCode { get; set; }
        public string MeasureDescription { get; set; }
        public int? LocationId { get; set; }
        public string LocationCode { get; set; }
        public decimal January { get; set; }
        public decimal JanuaryYtd { get; set; }
        public decimal February { get; set; }
        public decimal? FebruaryYtd { get; set; }
        public decimal March { get; set; }
        public decimal? MarchYtd { get; set; }
        public decimal? Q1total { get; set; }
        public decimal? Q1totalYtd { get; set; }
        public decimal April { get; set; }
        public decimal? AprilYtd { get; set; }
        public decimal May { get; set; }
        public decimal? MayYtd { get; set; }
        public decimal June { get; set; }
        public decimal? JuneYtd { get; set; }
        public decimal? Q2total { get; set; }
        public decimal? Q2totalYtd { get; set; }
        public decimal? FirstHalf { get; set; }
        public decimal? FirstHalfYtd { get; set; }
        public decimal July { get; set; }
        public decimal? JulyYtd { get; set; }
        public decimal August { get; set; }
        public decimal? AugustYtd { get; set; }
        public decimal September { get; set; }
        public decimal? SeptemberYtd { get; set; }
        public decimal? Q3total { get; set; }
        public decimal? Q3totalYtd { get; set; }
        public decimal October { get; set; }
        public decimal? OctoberYtd { get; set; }
        public decimal November { get; set; }
        public decimal? NovemberYtd { get; set; }
        public decimal December { get; set; }
        public decimal? DecemberYtd { get; set; }
        public decimal? Q4total { get; set; }
        public decimal? Q4totalYtd { get; set; }
        public decimal? SecondHalf { get; set; }
        public decimal? SecondHalfYtd { get; set; }
        public decimal? YearlyTotal { get; set; }
        public decimal? YearlyTotalYtd { get; set; }
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
