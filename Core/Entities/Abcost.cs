using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Abcost
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int ExpTypeId { get; set; }
        public decimal Amount { get; set; }
        public string Location { get; set; }
        public string WorkType { get; set; }

        public virtual Expenditure ExpType { get; set; }
        public virtual Abmaster Parent { get; set; }
    }
}
