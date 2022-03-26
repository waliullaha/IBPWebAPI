using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimDiparamPh
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ClaimDiparamMaster Parent { get; set; }
    }
}
