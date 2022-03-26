using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimP
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Channel { get; set; }
        public string ProgramCode { get; set; }
        public string ProgramName { get; set; }
        public string SlabName { get; set; }
        public string ProductCategory { get; set; }
        public int Enrolled { get; set; }
        public int Winner { get; set; }
        public decimal ClaimAmount { get; set; }
        public string GiftDescription { get; set; }
        public decimal GiftAmount { get; set; }
        public int? Abid { get; set; }
        public int StatusId { get; set; }
        public bool IsNewSystem { get; set; }

        public virtual ClaimMaster Parent { get; set; }
    }
}
