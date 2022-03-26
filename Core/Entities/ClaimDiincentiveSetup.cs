using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimDiincentiveSetup
    {
        public int Id { get; set; }
        public int GradeGroupId { get; set; }
        public int ParamId { get; set; }
        public int SlabId { get; set; }
        public decimal Incentive { get; set; }
        public decimal FlatAmount { get; set; }

        public virtual ClaimDigradeGroup GradeGroup { get; set; }
        public virtual ClaimDiparamMaster Param { get; set; }
        public virtual ClaimDiparamSlab Slab { get; set; }
    }
}
