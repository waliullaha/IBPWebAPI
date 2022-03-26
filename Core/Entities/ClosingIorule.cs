using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClosingIorule
    {
        public int Id { get; set; }
        public int Ioid { get; set; }
        public string Ph9code { get; set; }
        public decimal AllocationRule { get; set; }

        public virtual ClosingIomaster Io { get; set; }
    }
}
