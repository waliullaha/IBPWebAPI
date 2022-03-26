using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class PoemployeeGroup
    {
        public int Id { get; set; }
        public int GroupTypeId { get; set; }
        public string Employee { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
