using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimNsddetail
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string DelivaryNo { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Uom { get; set; }
        public int Quantity { get; set; }
        public decimal ListPrice { get; set; }
        public decimal PromotionFlag { get; set; }
        public decimal ClaimAmount { get; set; }
        public decimal GrossValue { get; set; }
        public decimal NetValue { get; set; }
        public int Abid { get; set; }
        public int StatusId { get; set; }

        public virtual ClaimMaster Parent { get; set; }
        public virtual ValueList Status { get; set; }
    }
}
