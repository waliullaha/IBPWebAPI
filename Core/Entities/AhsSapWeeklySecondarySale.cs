using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AhsSapWeeklySecondarySale
    {
        public string Gui { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int WeekNo { get; set; }
        public int Year { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ChannelName { get; set; }
        public decimal SalesQuantity { get; set; }
        public string Uom { get; set; }
        public decimal Nsv { get; set; }
        public decimal GrossSalesValue { get; set; }
        public string SalesOrganization { get; set; }
    }
}
