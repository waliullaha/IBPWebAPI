using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AvailibilityComplainView
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string StoreName { get; set; }
        public string StoreKeeperName { get; set; }
        public string StoreKeeperPhone { get; set; }
        public int? MarketId { get; set; }
        public string MarketName { get; set; }
        public string AssignedEmployee { get; set; }
        public string AssignedEmployeeName { get; set; }
        public string AssignedEmployeeEmail { get; set; }
        public string AssignedEmployeePhone { get; set; }
        public string LandMark { get; set; }
        public DateTime MatterDate { get; set; }
        public string RequesterComments { get; set; }
        public string Products { get; set; }
        public string ActionerComments { get; set; }
        public int StatusId { get; set; }
        public DateTime? SendDate { get; set; }
        public DateTime? ResolvedDate { get; set; }
        public DateTime? ReOpenDate { get; set; }
        public string Attachment { get; set; }
        public string EntryUserEmployee { get; set; }
        public string EntryUserEmployeeName { get; set; }
        public string EntryUserEmployeeEmail { get; set; }
        public string EntryUserEmployeePhone { get; set; }
        public string UpdateUserEmployee { get; set; }
        public string UpdateUserEmployeeName { get; set; }
        public string UpdateUserEmployeeEmail { get; set; }
        public string UpdateUserEmployeePhone { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Market { get; set; }
        public string Distributor { get; set; }
        public string MatterDateFormatted { get; set; }
        public string EntryDateFormatted { get; set; }
        public string UpdateDateFormatted { get; set; }
        public string Status { get; set; }
        public string Region { get; set; }
        public string Area { get; set; }
        public string Territory { get; set; }
        public string DistributorName { get; set; }
    }
}
