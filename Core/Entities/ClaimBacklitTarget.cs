using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimBacklitTarget
    {
        public int Id { get; set; }
        public DateTime FromMonth { get; set; }
        public DateTime ToMonth { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string Route { get; set; }
        public string OutletCode { get; set; }
        public string OutletName { get; set; }
        public string Channel { get; set; }
        public string BrandCode { get; set; }
        public string BrandName { get; set; }
        public int TotalLight { get; set; }
        public bool AuditCompleted { get; set; }
    }
}
