using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Abmaster
    {
        public Abmaster()
        {
            Abamends = new HashSet<Abamend>();
            AbauthoUsers = new HashSet<AbauthoUser>();
            AbbudgetPercentages = new HashSet<AbbudgetPercentage>();
            Abcosts = new HashSet<Abcost>();
            AbdeleteAuthorizations = new HashSet<AbdeleteAuthorization>();
            AbdetailsNavigation = new HashSet<Abdetail>();
            Abevcosts = new HashSet<Abevcost>();
            AbkeyAccounts = new HashSet<AbkeyAccount>();
            Abmrsuppliers = new HashSet<Abmrsupplier>();
            Abprices = new HashSet<Abprice>();
            Abproducts = new HashSet<Abproduct>();
            Abrois = new HashSet<Abroi>();
            Abtvcs = new HashSet<Abtvc>();
            ClaimBudgets = new HashSet<ClaimBudget>();
            HistoryAbmasters = new HashSet<HistoryAbmaster>();
            Pendings = new HashSet<Pending>();
        }

        public int Id { get; set; }
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
        public DateTime? ActionDate { get; set; }
        public int CompanyId { get; set; }

        public virtual ICollection<Abamend> Abamends { get; set; }
        public virtual ICollection<AbauthoUser> AbauthoUsers { get; set; }
        public virtual ICollection<AbbudgetPercentage> AbbudgetPercentages { get; set; }
        public virtual ICollection<Abcost> Abcosts { get; set; }
        public virtual ICollection<AbdeleteAuthorization> AbdeleteAuthorizations { get; set; }
        public virtual ICollection<Abdetail> AbdetailsNavigation { get; set; }
        public virtual ICollection<Abevcost> Abevcosts { get; set; }
        public virtual ICollection<AbkeyAccount> AbkeyAccounts { get; set; }
        public virtual ICollection<Abmrsupplier> Abmrsuppliers { get; set; }
        public virtual ICollection<Abprice> Abprices { get; set; }
        public virtual ICollection<Abproduct> Abproducts { get; set; }
        public virtual ICollection<Abroi> Abrois { get; set; }
        public virtual ICollection<Abtvc> Abtvcs { get; set; }
        public virtual ICollection<ClaimBudget> ClaimBudgets { get; set; }
        public virtual ICollection<HistoryAbmaster> HistoryAbmasters { get; set; }
        public virtual ICollection<Pending> Pendings { get; set; }
    }
}
