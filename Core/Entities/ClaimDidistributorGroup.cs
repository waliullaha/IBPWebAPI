using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimDidistributorGroup
    {
        public int Id { get; set; }
        public int GradeGroupId { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }

        public virtual ClaimDigradeGroup GradeGroup { get; set; }
    }
}
