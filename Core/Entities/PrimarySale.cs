using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class PrimarySale
    {
        public int InvoiceYear { get; set; }
        public int InvoiceMonth { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string DistributorCode { get; set; }
        public string TownName { get; set; }
        public string Tpcode { get; set; }
        public string Abnumber { get; set; }
        public string Sapskucode { get; set; }
        public string Skucode { get; set; }
        public string Skuname { get; set; }
        public decimal Qty { get; set; }
        public string UoM { get; set; }
        public int PackSize { get; set; }
        public decimal Lpvalue { get; set; }
        public decimal ListPrice { get; set; }
        public decimal Ddvalue { get; set; }
        public decimal Lpddprice { get; set; }
        public decimal AdvanceAmount { get; set; }
    }
}
