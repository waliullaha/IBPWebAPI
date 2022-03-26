using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AbactionLog
    {
        public int Id { get; set; }
        public int Abid { get; set; }
        public string Abnumber { get; set; }
        public string Action { get; set; }
        public int ActionUserId { get; set; }
        public string Description { get; set; }
        public string Screen { get; set; }
        public DateTime ActionDate { get; set; }
    }
}
