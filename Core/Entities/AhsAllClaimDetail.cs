using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AhsAllClaimDetail
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string ClaimNoDetail { get; set; }
        /// <summary>
        /// Damage-SKUCode,PerfectStore-ChannelName
        /// </summary>
        public string Skucode { get; set; }
        /// <summary>
        /// Damage-SKU,PerfectStore-ProgramName
        /// </summary>
        public string Sku { get; set; }
        /// <summary>
        /// Damage-PriceType,PerfectStore-Slab
        /// </summary>
        public string PriceType { get; set; }
        /// <summary>
        /// Damage-Amount,PerfectStore-ClaimAmount
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Damage-SKUCase,PerfectStore-NoOfWinner
        /// </summary>
        public int Skucase { get; set; }
        public int Skuunit { get; set; }
        /// <summary>
        /// Damage-ReasonCode,PerfectStore-Productcategory
        /// </summary>
        public string ReasonCode { get; set; }
        /// <summary>
        /// Damage-Place,PerfectStore-Enrolled Outlet
        /// </summary>
        public string Place { get; set; }
        /// <summary>
        /// Damage-TubeQty,PerfectStore-GiftDescription
        /// </summary>
        public string TubeQty { get; set; }
        public string DamageCost { get; set; }
        public string Empty1 { get; set; }
        public decimal GiftAmount { get; set; }
        public string InvoiceNo { get; set; }
    }
}
