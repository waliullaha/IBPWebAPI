using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class LocationEmployeeNew
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
        public int? CompanyId { get; set; }
    }
}
