using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Pending
    {
        public int Id { get; set; }
        public int Abid { get; set; }
        public string Abnumber { get; set; }
        public int Abtype { get; set; }
        public string Abdescription { get; set; }
        public decimal Abamount { get; set; }
        public DateTime ApprovalDate { get; set; }
        public int UserId { get; set; }
        public string Comments { get; set; }
        public int PendingType { get; set; }
        public bool IsUpdated { get; set; }
        public bool IsRejected { get; set; }

        public virtual Abmaster Ab { get; set; }
    }
}
