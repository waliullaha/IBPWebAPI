using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Absoamaster
    {
        public Absoamaster()
        {
            AbslabUsers = new HashSet<AbslabUser>();
            AbsoanegativeRois = new HashSet<AbsoanegativeRoi>();
            Absoaproducts = new HashSet<Absoaproduct>();
            AbsoaretrospectiveUsers = new HashSet<AbsoaretrospectiveUser>();
            AbsoarmfundUsers = new HashSet<AbsoarmfundUser>();
            Absoaslabs = new HashSet<Absoaslab>();
        }

        public int Id { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string GroupCode { get; set; }
        public int ModuleId { get; set; }
        public int ActivityTypeId { get; set; }
        public int PhlevelId { get; set; }
        public bool IsRmfund { get; set; }
        public bool IsNegativeRoi { get; set; }
        public bool IsRetrospective { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int CompanyId { get; set; }

        public virtual ModuleGl ActivityType { get; set; }
        public virtual Module Module { get; set; }
        public virtual ValueList Phlevel { get; set; }
        public virtual ICollection<AbslabUser> AbslabUsers { get; set; }
        public virtual ICollection<AbsoanegativeRoi> AbsoanegativeRois { get; set; }
        public virtual ICollection<Absoaproduct> Absoaproducts { get; set; }
        public virtual ICollection<AbsoaretrospectiveUser> AbsoaretrospectiveUsers { get; set; }
        public virtual ICollection<AbsoarmfundUser> AbsoarmfundUsers { get; set; }
        public virtual ICollection<Absoaslab> Absoaslabs { get; set; }
    }
}
