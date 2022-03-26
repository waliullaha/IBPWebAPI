using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class PrimarySalesDetail
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string InvoiceNo { get; set; }
        public string DelivaryNo { get; set; }
        public string CompanyCode { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string TownName { get; set; }
        public string SequenceNo { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Uom { get; set; }
        public int Quantity { get; set; }
        public decimal ListPrice { get; set; }
        public decimal PromotionFlag { get; set; }
        public decimal ClaimAmount { get; set; }
        public decimal GrossValue { get; set; }
        public decimal NetValue { get; set; }
        public bool IsNsd { get; set; }

        public virtual PrimarySalesMaster Parent { get; set; }
    }
}
