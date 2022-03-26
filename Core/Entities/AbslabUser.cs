using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AbslabUser
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int SoamasterId { get; set; }
        public int ApproverTypeId { get; set; }
        public int UserId { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }

        public virtual ValueList ApproverType { get; set; }
        public virtual Absoaslab Parent { get; set; }
        public virtual Absoamaster Soamaster { get; set; }
    }
}
