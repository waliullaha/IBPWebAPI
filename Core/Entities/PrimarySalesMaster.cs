using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class PrimarySalesMaster
    {
        public PrimarySalesMaster()
        {
            PrimarySalesDetails = new HashSet<PrimarySalesDetail>();
        }

        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string DistributorCode { get; set; }
        public string Sonumber { get; set; }
        public string Ponumber { get; set; }
        public string ShipmentNo { get; set; }
        public string DeliveryNo { get; set; }
        public decimal GrossValue { get; set; }
        public decimal Tax { get; set; }
        public decimal NetValue { get; set; }
        public DateTime InvoiceDueDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string VatChallanNo { get; set; }
        public string VatchallanDate { get; set; }
        public decimal Vatamount { get; set; }
        public string SalesOrganization { get; set; }
        public bool IsPodreceived { get; set; }
        public bool IsClaimCreated { get; set; }
        public DateTime? ClaimCreateDate { get; set; }

        public virtual ICollection<PrimarySalesDetail> PrimarySalesDetails { get; set; }
    }
}
