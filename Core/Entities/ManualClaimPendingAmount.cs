using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ManualClaimPendingAmount
    {
        public string DistributorCode { get; set; }
        public string TownName { get; set; }
        public string Region { get; set; }
        public string DistributorName { get; set; }
        public int PendingAmount { get; set; }
        public int CloseAmount { get; set; }
        public string UpdateDate { get; set; }
        public string PendingAmountFormatted { get; set; }
        public string UpdateDateFormatted { get; set; }
    }
}
