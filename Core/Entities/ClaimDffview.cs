using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimDffview
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string ProgramCode { get; set; }
        public string Name { get; set; }
        public string Kpiname { get; set; }
        public string Designation { get; set; }
        public decimal Target { get; set; }
        public decimal Achievement { get; set; }
        public decimal InitialClaimAmount { get; set; }
        public decimal ClaimAmount { get; set; }
        public int StatusId { get; set; }
        public int Abid { get; set; }
        public string DistributorGrade { get; set; }
        public bool IsNewSystem { get; set; }
        public string Status { get; set; }
        public string Abnumber { get; set; }
        public string ClaimAmountMillionFormat { get; set; }
    }
}
