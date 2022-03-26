using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Jccalendar
    {
        public int Id { get; set; }
        public string Jccode { get; set; }
        public int Jcyear { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
