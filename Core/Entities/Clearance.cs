using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Clearance
    {
        public int Id { get; set; }
        public string DistributorCode { get; set; }
        public bool IsAgreed { get; set; }
        public DateTime SubmitDate { get; set; }
        public int SubmitYear { get; set; }
        public int SubmissionTypeId { get; set; }
    }
}
