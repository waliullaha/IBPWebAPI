using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class LateClaimUploadCategorySetUp
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }
        public int DaysAllowedForCategory { get; set; }
        public DateTime AllowedDate { get; set; }
    }
}
