using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ArchiveClaimMaster
    {
        public int Id { get; set; }
        public string ClaimNo { get; set; }
        public string Obdno { get; set; }
        /// <summary>
        /// For Perfect Store Damage
        /// </summary>
        public DateTime ClaimDate { get; set; }
        public int ClaimMonth { get; set; }
        public int ClaimTypeId { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string DepotCode { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string TownName { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public int WorkflowUserId { get; set; }
        public string Soasteps { get; set; }
        public int StatusId { get; set; }
        public int? ClaimSendId { get; set; }
        public int BatchNo { get; set; }
        public DateTime? BatchDate { get; set; }
        public DateTime? ManualBatchDate { get; set; }
        public int? Abid { get; set; }
        public string ClaimAbnumber { get; set; }
        public string ErrorMessage { get; set; }
        public string Message { get; set; }
        public string DamageAbnumber { get; set; }
        public string DamageCbt { get; set; }
        public int? Enrolled { get; set; }
        public int? Winner { get; set; }
        public decimal ClaimPercentage { get; set; }
        public bool IsJvcreate { get; set; }
        public DateTime? JvcreateDate { get; set; }
        public bool IsJvcreateDamageQty { get; set; }
        public DateTime? JvdamageDate { get; set; }
        public DateTime? DepotApprovedDate { get; set; }
        public string OutletCode { get; set; }
        public bool IsVendorJv { get; set; }
        public DateTime? VendorJvdate { get; set; }
        public bool IsBankJv { get; set; }
        public DateTime? BankJvdate { get; set; }
        public bool IsTransferToBank { get; set; }
        public bool IsCustomerJv { get; set; }
        public DateTime? CustomerJvdate { get; set; }
        public bool IsNewSystem { get; set; }
        public int? AbtypeId { get; set; }
        public decimal Ait { get; set; }
        public int? CostCenterId { get; set; }
        public int? ClaimSetteledTypeId { get; set; }
        public bool IsChecked { get; set; }
        public string Reason { get; set; }
        public int? PreviousBatchNo { get; set; }
        public DateTime? PreviousBatchDate { get; set; }
        public string GlaccountNo { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
