using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AhsMailSendToDistributor
    {
        public int Id { get; set; }
        public string DistributorCode { get; set; }
        public string DamageEmail { get; set; }
        public string PerfectStoreEmail { get; set; }
        public string DistributorName { get; set; }
    }
}
