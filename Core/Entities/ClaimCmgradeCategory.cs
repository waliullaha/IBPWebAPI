using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimCmgradeCategory
    {
        public int Id { get; set; }
        public int SalaryStructureId { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public decimal Ta { get; set; }
        public decimal Da { get; set; }

        public virtual ClaimCmsalaryStructure SalaryStructure { get; set; }
    }
}
