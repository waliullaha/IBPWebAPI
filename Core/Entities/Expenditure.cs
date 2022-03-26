using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Expenditure
    {
        public Expenditure()
        {
            Abcosts = new HashSet<Abcost>();
        }

        public int Id { get; set; }
        public string Eh1code { get; set; }
        public string Eh1name { get; set; }
        public string Eh2code { get; set; }
        public string Eh2name { get; set; }
        public string Eh3code { get; set; }
        public string Eh3name { get; set; }
        public string Eh4code { get; set; }
        public string Eh4name { get; set; }
        public string Abmodules { get; set; }
        public int CompanyId { get; set; }

        public virtual ICollection<Abcost> Abcosts { get; set; }
    }
}
