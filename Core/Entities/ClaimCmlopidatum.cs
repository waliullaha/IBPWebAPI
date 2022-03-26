using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimCmlopidatum
    {
        public int Id { get; set; }
        public int MonthYear { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string EmployeeCode { get; set; }
        public int Attendance { get; set; }
        public int WorkingDays { get; set; }
        public bool IsAuthorized { get; set; }
    }
}
