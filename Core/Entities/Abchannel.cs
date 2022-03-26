using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Abchannel
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int ChannelId { get; set; }
    }
}
