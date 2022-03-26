using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class DepartmentView
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public bool IsActive { get; set; }
        public int ApplicationId { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
