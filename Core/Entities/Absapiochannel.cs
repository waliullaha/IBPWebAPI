using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Absapiochannel
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int ChannelId { get; set; }
    }
}
