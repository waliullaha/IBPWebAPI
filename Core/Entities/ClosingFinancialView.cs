using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClosingFinancialView
    {
        public int Ioid { get; set; }
        public int ClosingMonth { get; set; }
        public int ClosingYear { get; set; }
        public string Ionumber { get; set; }
        public string Abdescription { get; set; }
        public string Initiator { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string BudgetSubHead { get; set; }
        public decimal Ioamount { get; set; }
        public decimal ActualAmount { get; set; }
        public string Cbt { get; set; }
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
    }
}
