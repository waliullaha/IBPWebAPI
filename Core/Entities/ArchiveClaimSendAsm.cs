using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ArchiveClaimSendAsm
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public DateTime SendDate { get; set; }
        public string Asm { get; set; }
        public string Tm { get; set; }
        public string Description { get; set; }
    }
}
