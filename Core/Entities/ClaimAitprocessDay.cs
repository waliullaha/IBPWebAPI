using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimAitprocessDay
    {
        public int Id { get; set; }
        public int ClaimMasterId { get; set; }
        public DateTime ProcessDate { get; set; }
        public int StatusId { get; set; }
        public bool IsJvcreate { get; set; }
        public bool IsMonthCalculation { get; set; }
        public DateTime? CloseDate { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
