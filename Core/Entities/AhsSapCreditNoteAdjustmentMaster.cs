using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AhsSapCreditNoteAdjustmentMaster
    {
        public decimal Gui { get; set; }
        public string CreditNoteId { get; set; }
        public string OutletId { get; set; }
        public string DistributorId { get; set; }
        public string Pjpid { get; set; }
        public string SalesTeamId { get; set; }
        public string SalesmanId { get; set; }
        public string CompanyId { get; set; }
        public string Currency { get; set; }
        public string CreditNoteType { get; set; }
        public string CreditNoteReason { get; set; }
        public DateTime CreditNoteDate { get; set; }
        public decimal CreditNoteValue { get; set; }
        public string DeliveryAddress { get; set; }
        public string SalesOrganization { get; set; }
    }
}
