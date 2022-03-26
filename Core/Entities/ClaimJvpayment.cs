using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimJvpayment
    {
        public int Id { get; set; }
        public int ClaimMasterId { get; set; }
        public int ClaimCategoryId { get; set; }
        public string ClaimNo { get; set; }
        public string ReferenceNo { get; set; }
        public string PayeeName { get; set; }
        public string PayeeBankAccountNo { get; set; }
        public decimal Amount { get; set; }
        public string Reason { get; set; }
        public DateTime PaymentDate { get; set; }
        public string DebitAccountNo { get; set; }
        public string PayeeEmail { get; set; }
        public DateTime? PaymentStatusDate { get; set; }
        public int PaymentStatusId { get; set; }

        public virtual ValueList PaymentStatus { get; set; }
    }
}
