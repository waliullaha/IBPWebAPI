using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Supplier
    {
        public Supplier()
        {
            Abmrsuppliers = new HashSet<Abmrsupplier>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string ContactPerson { get; set; }
        public string Abmodules { get; set; }
        public bool IsActive { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int CompanyId { get; set; }

        public virtual ICollection<Abmrsupplier> Abmrsuppliers { get; set; }
    }
}
