using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimDiparamMasterView
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int ParamTypeId { get; set; }
        public int? SalesTypeId { get; set; }
        public int? PhlevelId { get; set; }
        public int? JoinTypeId { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string ParamType { get; set; }
        public string SalesType { get; set; }
        public string Phlevel { get; set; }
        public string JoinType { get; set; }
    }
}
