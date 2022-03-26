using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimPollydut
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string PollyduthName { get; set; }
        public string ProgramCode { get; set; }
        public string ProgramName { get; set; }
        public string Slab { get; set; }
        public string Payout { get; set; }
        public decimal Target { get; set; }
        public decimal Achievement { get; set; }
        public string GiftType { get; set; }
        public decimal GiftRate { get; set; }
        public int? Abid { get; set; }
        public decimal ClaimAmount { get; set; }
        public int StatusId { get; set; }
        public bool? IsNewSystem { get; set; }

        public virtual ClaimMaster Parent { get; set; }
    }
}
