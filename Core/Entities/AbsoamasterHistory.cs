using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AbsoamasterHistory
    {
        public int Id { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string GroupCode { get; set; }
        public int ModuleId { get; set; }
        public int ActivityTypeId { get; set; }
        public int PhlevelId { get; set; }
        public bool IsRmfund { get; set; }
        public bool IsNegativeRoi { get; set; }
        public bool IsRetrospective { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int CompanyId { get; set; }
    }
}
