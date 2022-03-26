using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Abmaster1
    {
        public int Id { get; set; }
        public int Abtype { get; set; }
        public int AbslNo { get; set; }
        public string Abnumber { get; set; }
        public string Description { get; set; }
        public DateTime Abdate { get; set; }
        public DateTime ClosureDate { get; set; }
        public DateTime ApprovalDate { get; set; }
        public DateTime ActivityStartDate { get; set; }
        public DateTime ActivityEndDate { get; set; }
        public string Abdetails { get; set; }
        public decimal Abamount { get; set; }
        public decimal Npiamount { get; set; }
        public decimal ClaimAmount { get; set; }
        public int SystemType { get; set; }
        public int InvoiceDiscountType { get; set; }
        public string ProfitCenter { get; set; }
        public string ChargeAccount { get; set; }
        public string ProvisionAccount { get; set; }
        public string PaymentAccount { get; set; }
        public bool IsAgreed { get; set; }
        public bool IsApproved { get; set; }
        public bool IsAuthorised { get; set; }
        public bool IsSend { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsAmended { get; set; }
        public int AmendTimes { get; set; }
        public bool IsFdconsult { get; set; }
        public int ClaimTypeId { get; set; }
        public bool IsBudgeted { get; set; }
    }
}
