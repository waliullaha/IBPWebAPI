using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class PendingBill
    {
        public int Id { get; set; }
        public string BillNo { get; set; }
        public DateTime BillDate { get; set; }
        public int? PlanId { get; set; }
        public decimal Amount { get; set; }
        public string BillDetail { get; set; }
    }
}
