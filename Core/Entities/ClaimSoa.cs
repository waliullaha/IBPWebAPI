using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimSoa
    {
        public int Id { get; set; }
        public int ClaimCategoryId { get; set; }
        public int UserTypeId { get; set; }
        public decimal MinValue { get; set; }
        public decimal MaxValue { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ValueList ClaimCategory { get; set; }
        public virtual ValueList UserType { get; set; }
    }
}
