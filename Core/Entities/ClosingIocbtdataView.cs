using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClosingIocbtdataView
    {
        public int Ioid { get; set; }
        public string PnLcbt { get; set; }
        public decimal? Ytdamount { get; set; }
        public string ChargeCode { get; set; }
        public string ChargeDescription { get; set; }
        public string ProvisionCode { get; set; }
        public string ProvisionDescription { get; set; }
        public string PaymentCode { get; set; }
        public string PaymentDescription { get; set; }
    }
}
