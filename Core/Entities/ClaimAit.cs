using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimAit
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public decimal Aitamount { get; set; }

        public virtual ClaimMaster Parent { get; set; }
    }
}
