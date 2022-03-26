using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimAutoBatchCreationView
    {
        public int ClaimTypeId { get; set; }
        public int? MaxBatchNo { get; set; }
        public string ClaimIds { get; set; }
        public int? Total { get; set; }
    }
}
