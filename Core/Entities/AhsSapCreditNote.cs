using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AhsSapCreditNote
    {
        public decimal Gui { get; set; }
        public string SalesDocumentType { get; set; }
        public string SalesOrganization { get; set; }
        public string DistributionChannel { get; set; }
        public string Division { get; set; }
        public string SoldToParty { get; set; }
        public string ShipToParty { get; set; }
        public string CreditNoteDate { get; set; }
        public string ProductCode { get; set; }
        public int ProductQuantity { get; set; }
        public string ConditionType { get; set; }
        public decimal ClaimAmount { get; set; }
        public string CurrencyCode { get; set; }
        public string ReasonCode { get; set; }
        public string Ionumber { get; set; }
        public string PromotionCode { get; set; }
        public bool IsFileCreated { get; set; }
        public string ClaimNo { get; set; }
        public DateTime? ProcessedDate { get; set; }
    }
}
