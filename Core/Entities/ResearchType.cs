using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ResearchType
    {
        public int Id { get; set; }
        public int ResearchTypeId { get; set; }
        public string Description { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int CompanyId { get; set; }

        public virtual ValueList ResearchTypeNavigation { get; set; }
    }
}
