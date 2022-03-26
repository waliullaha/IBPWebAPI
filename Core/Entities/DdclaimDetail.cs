using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class DdclaimDetail
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public DateTime SalesDate { get; set; }
        public string Tprcode { get; set; }
        public string Skucode { get; set; }
        public string Skuname { get; set; }
        public int PurchaseQuantity { get; set; }
        public decimal ListValue { get; set; }
        public decimal DdlistValue { get; set; }
        public decimal Advance { get; set; }
        public int SalesQty { get; set; }
        public int DdsalesQty { get; set; }
        public decimal DdsalesValueLp { get; set; }
        public decimal CashDiscountTp { get; set; }
        public decimal DdtotalLp { get; set; }
        public int Abid { get; set; }

        public virtual DdclaimMaster Parent { get; set; }
    }
}
