using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Absoaslab
    {
        public Absoaslab()
        {
            AbslabUsers = new HashSet<AbslabUser>();
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Description { get; set; }
        public decimal MaxValue { get; set; }
        public decimal MinValue { get; set; }

        public virtual Absoamaster Parent { get; set; }
        public virtual ICollection<AbslabUser> AbslabUsers { get; set; }
    }
}
