using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class LocationEmployeeView
    {
        public int Id { get; set; }
        public string Employee { get; set; }
        public string Location { get; set; }
        public string ParentLocation { get; set; }
        public int LocationTypeId { get; set; }
        public int EntryUserId { get; set; }
        public string EntryDate { get; set; }
        public int UpdateUserId { get; set; }
        public string UpdateDate { get; set; }
    }
}
