using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimTypeTag
    {
        public int Id { get; set; }
        public int ClaimTypeId { get; set; }
        public int AbmoduleId { get; set; }

        public virtual Module Abmodule { get; set; }
        public virtual ValueList ClaimType { get; set; }
    }
}
