using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class LocationEmployee2
    {
        public int Id { get; set; }
        public string Employee { get; set; }
        public string Location { get; set; }
        public string ParentLocation { get; set; }
        public int LocationTypeId { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Employee1 { get; set; }

        public virtual ValueList LocationType { get; set; }
    }
}
