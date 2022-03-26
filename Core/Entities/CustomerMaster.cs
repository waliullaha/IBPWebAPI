using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class CustomerMaster
    {
        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string TownName { get; set; }
        public string VendorCode { get; set; }
        public string VendorName { get; set; }
        public string AccGroup { get; set; }
        public string BankKey { get; set; }
        public string BankAccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public string RoutingNo { get; set; }
        public string Email { get; set; }
    }
}
