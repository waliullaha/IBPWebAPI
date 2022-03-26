using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Pomarket
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Distributor { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
