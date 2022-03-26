using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimDamageOmrarchive
    {
        public int Id { get; set; }
        public string Plant { get; set; }
        public string SoldToParty { get; set; }
        public string SoldName { get; set; }
        public string PoNumber { get; set; }
        public string DefectCode { get; set; }
        public string ShipToParty { get; set; }
        public string SalesDocument { get; set; }
        public string Delivery { get; set; }
        public string OrderCreationDate { get; set; }
        public string Material { get; set; }
        public string MaterialDescription { get; set; }
        public string PackSizeDescription { get; set; }
        public int DeliveryQuantity { get; set; }
        public int OrderQuantity { get; set; }
        public int BilledQuantity { get; set; }
        public string BillingDocument { get; set; }
        public string BillingDate { get; set; }
        public decimal NetTax { get; set; }
        public decimal NetPrice { get; set; }
        public bool IsClaimCreated { get; set; }
        public DateTime? ClaimCreatedDate { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? EntryDateInt { get; set; }
        public string EntryDateStr { get; set; }
    }
}
