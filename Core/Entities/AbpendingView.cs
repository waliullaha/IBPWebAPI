using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AbpendingView
    {
        public int Id { get; set; }
        public int Abid { get; set; }
        public string Abnumber { get; set; }
        public int Abtype { get; set; }
        public string Abdescription { get; set; }
        public decimal Abamount { get; set; }
        public DateTime ApprovalDate { get; set; }
        public int UserId { get; set; }
        public string Comments { get; set; }
        public int PendingType { get; set; }
        public bool IsUpdated { get; set; }
        public bool IsRejected { get; set; }
        public string LoginId { get; set; }
        public string FullName { get; set; }
        public string ApproverName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string Module { get; set; }
        public int EntryUserId { get; set; }
        public bool IsSend { get; set; }
        public bool IsAuthorised { get; set; }
        public DateTime ActivityStartDate { get; set; }
        public string Abdetails { get; set; }
        public string PendingStatus { get; set; }
        public int? PendingType1 { get; set; }
        public string AbamountMillionFormat { get; set; }
        public int CompanyId { get; set; }
    }
}
