using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimCmdistributorEmployee
    {
        public int Id { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string FatherName { get; set; }
        public string Education { get; set; }
        public string MobileNo { get; set; }
        public DateTime JoinDate { get; set; }
        public int Experience { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? InactiveDate { get; set; }
    }
}
