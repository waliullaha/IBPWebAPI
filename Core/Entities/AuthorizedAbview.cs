using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AuthorizedAbview
    {
        public int Id { get; set; }
        public string Abnumber { get; set; }
        public string Description { get; set; }
        public DateTime? Abdate { get; set; }
        public decimal Abamount { get; set; }
        public bool IsAuthorised { get; set; }
        public bool IsDeleted { get; set; }
        public int EntryUserId { get; set; }
        public string Status { get; set; }
        public int StatusId { get; set; }
        public int? AuthoriseUserId { get; set; }
    }
}
