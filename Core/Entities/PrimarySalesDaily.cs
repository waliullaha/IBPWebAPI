using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class PrimarySalesDaily
    {
        public int Id { get; set; }
        public DateTime SalesDate { get; set; }
        public string Skucode { get; set; }
        public string Skuname { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public decimal SalesQuantity { get; set; }
        public decimal DamageQuantity { get; set; }
        public decimal TotalQuantity { get; set; }
        public int PackSize { get; set; }
        public decimal Mrp { get; set; }
        public decimal Tp { get; set; }
        public decimal Lp { get; set; }
        public decimal Mrptp { get; set; }
        public decimal Mrplp { get; set; }
        public decimal Tplp { get; set; }
    }
}
