using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class DdclaimMaster
    {
        public DdclaimMaster()
        {
            DdclaimDetails = new HashSet<DdclaimDetail>();
            DdclaimSendAsms = new HashSet<DdclaimSendAsm>();
        }

        public int Id { get; set; }
        public string ClaimNo { get; set; }
        /// <summary>
        /// For Perfect Store Damage
        /// </summary>
        public DateTime ClaimDate { get; set; }
        public int ClaimMonth { get; set; }
        public int ClaimTypeId { get; set; }
        public int? Abid { get; set; }
        public string Abnumber { get; set; }
        public decimal AdvanceAmount { get; set; }
        public decimal DdtotalAmount { get; set; }
        public decimal DifferanceAmount { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string TownName { get; set; }
        public string Comments { get; set; }
        public int WorkflowUserId { get; set; }
        public int StatusId { get; set; }
        public int? ClaimSendId { get; set; }
        public int BatchNo { get; set; }
        public DateTime? BatchDate { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsJvcreateGsv { get; set; }
        public DateTime? JvcreateDateGsv { get; set; }
        public bool IsJvcreateDistributor { get; set; }
        public DateTime? JvcreateDateDistributor { get; set; }
        public bool IsJvcreateCompany { get; set; }
        public DateTime? JvcreateDateCompany { get; set; }
        public bool IsJvcreateFinal { get; set; }
        public DateTime? JvcreateDateFinal { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ValueList ClaimType { get; set; }
        public virtual ICollection<DdclaimDetail> DdclaimDetails { get; set; }
        public virtual ICollection<DdclaimSendAsm> DdclaimSendAsms { get; set; }
    }
}
