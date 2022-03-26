using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimJvddicollection
    {
        public int Id { get; set; }
        public int ClaimMasterId { get; set; }
        public int ClaimCategoryId { get; set; }
        public string ClaimNo { get; set; }
        public string ReferenceNo { get; set; }
        public string DebitAccountNo { get; set; }
        public string DebitAccountName { get; set; }
        public DateTime CreateDate { get; set; }
        public string RoutingNo { get; set; }
        public decimal Amount { get; set; }
        public DateTime? PaymentStatusDate { get; set; }
        public int PaymentStatusId { get; set; }
        public string Remark { get; set; }

        public virtual ValueList PaymentStatus { get; set; }
    }
}
