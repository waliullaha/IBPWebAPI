using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class TempSoa
    {
        public int? ApproverTypeId { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public decimal? SlabAmount { get; set; }
    }
}
