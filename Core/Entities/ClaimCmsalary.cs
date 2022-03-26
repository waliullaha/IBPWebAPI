using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimCmsalary
    {
        public int Id { get; set; }
        public int MonthYear { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string EmployeeCode { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Ta { get; set; }
        public decimal Da { get; set; }
        public decimal Hopi { get; set; }
        public decimal Lopi { get; set; }
        public int Bonus { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
