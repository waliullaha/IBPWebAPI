using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ArchiveClaimManual
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public decimal SetteledAmount { get; set; }
        public DateTime? SetteledDate { get; set; }
        public string Comments { get; set; }
        public bool? IsPartialSettelement { get; set; }
        public int? BatchNo { get; set; }
        public DateTime? BatchDate { get; set; }
        public int Aitid { get; set; }
        public decimal Aitamount { get; set; }
    }
}
