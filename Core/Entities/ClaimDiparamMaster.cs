using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimDiparamMaster
    {
        public ClaimDiparamMaster()
        {
            ClaimDiincentiveSetups = new HashSet<ClaimDiincentiveSetup>();
            ClaimDiparamPhs = new HashSet<ClaimDiparamPh>();
            ClaimDiparamScs = new HashSet<ClaimDiparamSc>();
            ClaimDiparamSlabs = new HashSet<ClaimDiparamSlab>();
            ClaimDiprocessData = new HashSet<ClaimDiprocessDatum>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int ParamTypeId { get; set; }
        /// <summary>
        /// 0-None,1-Primary Sales,2-Secondary Sales
        /// </summary>
        public int? SalesTypeId { get; set; }
        public int? PhlevelId { get; set; }
        /// <summary>
        /// 0-None,1-And,2=Or
        /// </summary>
        public int? JoinTypeId { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ValueList JoinType { get; set; }
        public virtual ValueList ParamType { get; set; }
        public virtual ValueList Phlevel { get; set; }
        public virtual ValueList SalesType { get; set; }
        public virtual ICollection<ClaimDiincentiveSetup> ClaimDiincentiveSetups { get; set; }
        public virtual ICollection<ClaimDiparamPh> ClaimDiparamPhs { get; set; }
        public virtual ICollection<ClaimDiparamSc> ClaimDiparamScs { get; set; }
        public virtual ICollection<ClaimDiparamSlab> ClaimDiparamSlabs { get; set; }
        public virtual ICollection<ClaimDiprocessDatum> ClaimDiprocessData { get; set; }
    }
}
