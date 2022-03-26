using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimDiparamSlab
    {
        public ClaimDiparamSlab()
        {
            ClaimDiincentiveSetups = new HashSet<ClaimDiincentiveSetup>();
            ClaimDiprocessData = new HashSet<ClaimDiprocessDatum>();
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public decimal Minimum { get; set; }
        public decimal Maximum { get; set; }

        public virtual ClaimDiparamMaster Parent { get; set; }
        public virtual ICollection<ClaimDiincentiveSetup> ClaimDiincentiveSetups { get; set; }
        public virtual ICollection<ClaimDiprocessDatum> ClaimDiprocessData { get; set; }
    }
}
