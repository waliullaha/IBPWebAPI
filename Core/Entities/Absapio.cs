using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Absapio
    {
        public int Id { get; set; }
        public string Ionumber { get; set; }
        public int AbtypeId { get; set; }
        public int ChannelId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsProcessed { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
