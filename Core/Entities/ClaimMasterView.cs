using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimMasterView
    {
        public int Id { get; set; }
        public string ClaimNo { get; set; }
        public string Obdno { get; set; }
        public DateTime ClaimDate { get; set; }
        public int ClaimMonth { get; set; }
        public int ClaimTypeId { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string DepotCode { get; set; }
        public string DistributorCode { get; set; }
        public int? CostCenterId { get; set; }
        public string DistributorName { get; set; }
        public string TownName { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public int WorkflowUserId { get; set; }
        public string Soasteps { get; set; }
        public int StatusId { get; set; }
        public int BatchNo { get; set; }
        public int? Abid { get; set; }
        public string ClaimAbnumber { get; set; }
        public string ErrorMessage { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string ClaimType { get; set; }
        public string StatusDetail { get; set; }
        public string Abnumber { get; set; }
        public bool IsJvcreate { get; set; }
        public bool IsJvcreateDamageQty { get; set; }
        public DateTime? ManualBatchDate { get; set; }
        public string ClaimAmountMillionFormat { get; set; }
        public int? ClaimSendId { get; set; }
        public DateTime? JvdamageDate { get; set; }
        public DateTime? JvcreateDate { get; set; }
        public int? ClaimSetteledTypeId { get; set; }
        public decimal ClaimPercentage { get; set; }
        public int RunningPercentage { get; set; }
        public int YtddamageAmount { get; set; }
        public int DamageSalesValue { get; set; }
        public string Message { get; set; }
        public string WorkFlowUserName { get; set; }
        public string Region { get; set; }
        public string RegionCode { get; set; }
        public string Area { get; set; }
        public string AreaCode { get; set; }
        public string Territory { get; set; }
        public string TerritoryCode { get; set; }
        public int? Winner { get; set; }
        public int? Enrolled { get; set; }
        public string OutletCode { get; set; }
        public string ProgramMonth { get; set; }
        public string GlaccountNo { get; set; }
        public string Status { get; set; }
        public string ManualStatus { get; set; }
        public string ForOrderBy { get; set; }
        public int ClaimCategoryId { get; set; }
        public string TownName1 { get; set; }
        public string ClaimDateFormatted { get; set; }
        public string FromDateFormatted { get; set; }
        public string ToDateFormatted { get; set; }
        public string ClaimFromDate { get; set; }
        public string ClaimToDate { get; set; }
        public string EmptyComments { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonDescription { get; set; }
        public bool IsVendorJv { get; set; }
        public bool IsBankJv { get; set; }
        public bool IsCustomerJv { get; set; }
        public DateTime? VendorJvdate { get; set; }
        public DateTime? BankJvdate { get; set; }
        public bool IsTransferToBank { get; set; }
        public DateTime? CustomerJvdate { get; set; }
        public string CompanyCode { get; set; }
        public string Category { get; set; }
    }
}
