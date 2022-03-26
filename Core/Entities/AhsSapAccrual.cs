using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AhsSapAccrual
    {
        public decimal Gui { get; set; }
        public int DocumentNo { get; set; }
        public string DocumentDate { get; set; }
        public string DocumentType { get; set; }
        public string CompanyCode { get; set; }
        public string PostingDate { get; set; }
        public string Period { get; set; }
        public string CurrencyKey { get; set; }
        public string Reference { get; set; }
        public string DocumentHeader { get; set; }
        public string PostingKey { get; set; }
        public string Account { get; set; }
        public decimal Amount { get; set; }
        public string ItemText { get; set; }
        public string ProfitCenter { get; set; }
    }
}
