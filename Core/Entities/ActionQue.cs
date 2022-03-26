using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ActionQue
    {
        public int Id { get; set; }
        public int Abid { get; set; }
        public int ActionUserId { get; set; }
        public DateTime ActionDate { get; set; }
        public int ActionType { get; set; }
        public int PendingType { get; set; }
        public DateTime? ProcessDate { get; set; }
        public bool IsProcessed { get; set; }
        public string Comments { get; set; }
    }
}
