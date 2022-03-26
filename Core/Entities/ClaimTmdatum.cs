using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimTmdatum
    {
        public int Id { get; set; }
        public int WfsetupMasterId { get; set; }
        public int WfsetupDetailId { get; set; }
        public int Step { get; set; }
        public int InitiatorId { get; set; }
        public string InitiatorName { get; set; }
        public int FromEmployeeId { get; set; }
        public string FromEmployeeName { get; set; }
        public int ToEmployeeId { get; set; }
        public string ToEmployeeName { get; set; }
        public int RequisitionId { get; set; }
        public string RequisitionNo { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string Comments { get; set; }
        public string Status { get; set; }
    }
}
