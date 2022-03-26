using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimCategoryWiseClaimType
    {
        public int Id { get; set; }
        public int ClaimCategoryId { get; set; }
        public int ClaimTypeId { get; set; }
    }
}
