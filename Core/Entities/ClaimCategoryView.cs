using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimCategoryView
    {
        public int Id { get; set; }
        public string ClaimCategoryName { get; set; }
        public string ClaimTypeId { get; set; }
    }
}
