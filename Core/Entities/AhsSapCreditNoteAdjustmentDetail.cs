using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AhsSapCreditNoteAdjustmentDetail
    {
        public decimal Gui { get; set; }
        public string Sku { get; set; }
        public string Uom { get; set; }
        public decimal CreditNoteLineValue { get; set; }
        public decimal CreditNoteLineVolume { get; set; }
        public string CreditNoteType { get; set; }
        public string CreditNoteLineId { get; set; }
        public string SalesOrganization { get; set; }
    }
}
