using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Abmrsupplier
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int SupplierId { get; set; }
        public string AgencySelection { get; set; }
        public string ActionStandard { get; set; }

        public virtual Abmaster Parent { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
