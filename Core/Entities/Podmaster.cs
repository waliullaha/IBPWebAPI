using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Podmaster
    {
        public int Id { get; set; }
        public string DeliveryNo { get; set; }
        public string ActualReceiveDate { get; set; }
        public string ActualReceiveTime { get; set; }
        public string IdocSystemDate { get; set; }
        public string IdocCreationSystemDate { get; set; }
        public string UpdateUser { get; set; }
        public string UpdateTransaction { get; set; }
        public string InterfaceProgram { get; set; }
        public string Status { get; set; }
        public string TimeStamp { get; set; }
        public int LineItem { get; set; }
        public string MaterialCode { get; set; }
    }
}
