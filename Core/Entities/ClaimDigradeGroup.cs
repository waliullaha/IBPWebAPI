using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimDigradeGroup
    {
        public ClaimDigradeGroup()
        {
            ClaimDidistributorGroups = new HashSet<ClaimDidistributorGroup>();
            ClaimDiincentiveSetups = new HashSet<ClaimDiincentiveSetup>();
        }

        public int Id { get; set; }
        public int GradeId { get; set; }
        public int GroupId { get; set; }

        public virtual ValueList Grade { get; set; }
        public virtual ValueList Group { get; set; }
        public virtual ICollection<ClaimDidistributorGroup> ClaimDidistributorGroups { get; set; }
        public virtual ICollection<ClaimDiincentiveSetup> ClaimDiincentiveSetups { get; set; }
    }
}
