using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class KeyAccount
    {
        public KeyAccount()
        {
            AbkeyAccounts = new HashSet<AbkeyAccount>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int CompanyId { get; set; }

        public virtual ICollection<AbkeyAccount> AbkeyAccounts { get; set; }
    }
}
