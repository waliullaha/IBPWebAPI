using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Abamend
    {
        public int Id { get; set; }
        public int Abid { get; set; }
        public int Abtype { get; set; }
        public int InitiatedBy { get; set; }
        public DateTime PrevActStartDate { get; set; }
        public DateTime CurrActStartDate { get; set; }
        public DateTime PrevActEndDate { get; set; }
        public DateTime CurrActEndDate { get; set; }
        public decimal PrevAbamount { get; set; }
        public decimal CurrAbamount { get; set; }
        public decimal PrevNpiamount { get; set; }
        public decimal CurrNpiamount { get; set; }
        public decimal PrevClaimAmount { get; set; }
        public decimal CurrClaimAmount { get; set; }
        public string PrevAbobjective { get; set; }
        public string CurrAbobjective { get; set; }
        public string PrevAbdetails { get; set; }
        public string CurrAbdetails { get; set; }
        public bool IsSend { get; set; }
        public int AmendNo { get; set; }
        public string Comment { get; set; }

        public virtual Abmaster Ab { get; set; }
    }
}
