using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class PoemployeeRole
    {
        public int Id { get; set; }
        public string Employee { get; set; }
        public bool PowerUser { get; set; }
        public bool Administrator { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
