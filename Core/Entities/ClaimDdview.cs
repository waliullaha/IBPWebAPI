using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimDdview
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Skucode { get; set; }
        public string MasterSkuname { get; set; }
        public int Skucase { get; set; }
        public int Skuunit { get; set; }
        public string FreeSkucode { get; set; }
        public string FreeSkuname { get; set; }
        public int FreeSkucase { get; set; }
        public int FreeSkuunit { get; set; }
        public int TotalQuantity { get; set; }
        public decimal ClaimAmount { get; set; }
        public string PromotionCode { get; set; }
        public int StatusId { get; set; }
        public int Abid { get; set; }
        public bool IsNewSystem { get; set; }
        public string Status { get; set; }
        public string Abnumber { get; set; }
        public string ClaimAmountMillionFormat { get; set; }
    }
}
