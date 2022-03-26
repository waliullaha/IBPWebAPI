using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class DdclaimMasterView
    {
        public int Id { get; set; }
        public string ClaimNo { get; set; }
        public DateTime ClaimDate { get; set; }
        public int ClaimMonth { get; set; }
        public int ClaimTypeId { get; set; }
        public decimal AdvanceAmount { get; set; }
        public decimal DdtotalAmount { get; set; }
        public decimal DifferanceAmount { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string TownName { get; set; }
        public string Comments { get; set; }
        public int WorkflowUserId { get; set; }
        public int StatusId { get; set; }
        public int BatchNo { get; set; }
        public int? Abid { get; set; }
        public string Abnumber { get; set; }
        public string ErrorMessage { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string ClaimType { get; set; }
        public string StatusDetail { get; set; }
        public bool IsJvcreateGsv { get; set; }
        public bool IsJvcreateCompany { get; set; }
        public bool IsJvcreateDistributor { get; set; }
        public bool IsJvcreateFinal { get; set; }
        public string AdvanceAmountMillionFormat { get; set; }
        public int? ClaimSendId { get; set; }
        public string Status { get; set; }
        public string ForOrderBy { get; set; }
        public int ClaimCategoryId { get; set; }
        public string TownName1 { get; set; }
        public string ClaimDateFormatted { get; set; }
        public string Category { get; set; }
    }
}
