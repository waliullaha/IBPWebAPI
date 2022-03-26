using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class DailySecondarySalse
    {
        public int Id { get; set; }
        public DateTime SalesDate { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string TownName { get; set; }
        public string Abnumber { get; set; }
        public int? Abid { get; set; }
        public string Tprcode { get; set; }
        public string Skucode { get; set; }
        public string Skuname { get; set; }
        public int SalesQty { get; set; }
        public int DdsalesQty { get; set; }
        public decimal DdsalesValueLp { get; set; }
        public decimal CashDiscountTp { get; set; }
        public decimal DdtotalLp { get; set; }
        public int StatusId { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsSendToTm { get; set; }
    }
}
