using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClosingIocbt
    {
        public int Id { get; set; }
        public int Ioid { get; set; }
        public string PnLcbt { get; set; }
        public decimal Ytdamount { get; set; }

        public virtual ClosingIomaster Io { get; set; }
    }
}
