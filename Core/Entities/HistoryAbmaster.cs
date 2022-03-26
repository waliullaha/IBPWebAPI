using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class HistoryAbmaster
    {
        public HistoryAbmaster()
        {
            HistoryAbauthoUsers = new HashSet<HistoryAbauthoUser>();
            HistoryAbdetails = new HashSet<HistoryAbdetail>();
            HistoryAbproducts = new HashSet<HistoryAbproduct>();
        }

        public int Id { get; set; }
        public int Abid { get; set; }
        public int Abtype { get; set; }
        public int AbslNo { get; set; }
        public string Abnumber { get; set; }
        public string Description { get; set; }
        public DateTime? Abdate { get; set; }
        public DateTime ClosureDate { get; set; }
        public DateTime ApprovalDate { get; set; }
        public DateTime ActivityStartDate { get; set; }
        public DateTime ActivityEndDate { get; set; }
        public string Abdetails { get; set; }
        public decimal Abamount { get; set; }
        public decimal Npiamount { get; set; }
        public decimal ClaimAmount { get; set; }
        /// <summary>
        /// 0-None,1-Ariba,2-Non-Ariba
        /// </summary>
        public int SystemType { get; set; }
        /// <summary>
        /// 1-off invoice,2- on invoice
        /// </summary>
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
        public int? ClaimTypeId { get; set; }
        public bool? IsBudgeted { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int CompanyId { get; set; }

        public virtual Abmaster Ab { get; set; }
        public virtual ICollection<HistoryAbauthoUser> HistoryAbauthoUsers { get; set; }
        public virtual ICollection<HistoryAbdetail> HistoryAbdetails { get; set; }
        public virtual ICollection<HistoryAbproduct> HistoryAbproducts { get; set; }
    }
}
