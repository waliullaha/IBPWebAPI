using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClosingIomaster
    {
        public ClosingIomaster()
        {
            ClosingIocbts = new HashSet<ClosingIocbt>();
            ClosingIodetails = new HashSet<ClosingIodetail>();
            ClosingIorules = new HashSet<ClosingIorule>();
        }

        public int Id { get; set; }
        public int? Abid { get; set; }
        public int? Abtype { get; set; }
        public string Ionumber { get; set; }
        public string Abnumber { get; set; }
        public string Description { get; set; }
        public string Initiator { get; set; }
        public DateTime ActivityStartDate { get; set; }
        public DateTime ActivityEndDate { get; set; }
        public decimal Ioamount { get; set; }
        public decimal ActualAmount { get; set; }
        public int ActivityTypeId { get; set; }
        public string BudgetSubHead { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<ClosingIocbt> ClosingIocbts { get; set; }
        public virtual ICollection<ClosingIodetail> ClosingIodetails { get; set; }
        public virtual ICollection<ClosingIorule> ClosingIorules { get; set; }
    }
}
