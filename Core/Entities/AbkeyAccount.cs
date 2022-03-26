using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AbkeyAccount
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int KeyAccountId { get; set; }

        public virtual KeyAccount KeyAccount { get; set; }
        public virtual Abmaster Parent { get; set; }
    }
}
