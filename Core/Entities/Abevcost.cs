using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Abevcost
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Description { get; set; }
        public int SourceId { get; set; }
        public string Skucode { get; set; }
        public string MediaUsed { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }

        public virtual Abmaster Parent { get; set; }
    }
}
