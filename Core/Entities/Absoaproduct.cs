using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Absoaproduct
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Skucode { get; set; }
        public string Skuname { get; set; }

        public virtual Absoamaster Parent { get; set; }
    }
}
