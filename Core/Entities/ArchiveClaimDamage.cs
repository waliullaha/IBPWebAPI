using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ArchiveClaimDamage
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Skucode { get; set; }
        public string Skuname { get; set; }
        public string DefectCode { get; set; }
        public string DefectDescription { get; set; }
        public string Place { get; set; }
        public decimal ListPrice { get; set; }
        public decimal TradePrice { get; set; }
        public decimal ClaimPrice { get; set; }
        public int Skucase { get; set; }
        public int Skuunit { get; set; }
        /// <summary>
        /// IF Place = C or D, then ClaimPrice * (SKUCase * PackSize) + SKUUnit else TradePrice * (SKUCase * PackSize) + SKUUnit
        /// </summary>
        public decimal ClaimAmount { get; set; }
        public int PackSize { get; set; }
        /// <summary>
        /// (SKUCase * PackSize) + SKUUnit
        /// </summary>
        public int InitialQuantity { get; set; }
        public string ParentCode { get; set; }
        public string ParentDescription { get; set; }
        public string Remarks { get; set; }
        public string DamageReason { get; set; }
        public bool IsNsd { get; set; }
    }
}
