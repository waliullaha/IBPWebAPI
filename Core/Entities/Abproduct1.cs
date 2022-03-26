using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Abproduct1
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Ph8code { get; set; }
        public string Ph9code { get; set; }
        public string Ph10code { get; set; }
        public bool? MasterItem { get; set; }
        public string Location { get; set; }
        public int? ExpTypeId { get; set; }
        public decimal Abratio { get; set; }
        public decimal Npsratio { get; set; }
        public decimal PromoInputValue { get; set; }
        public decimal PromoActualValue { get; set; }
        public decimal TargetVolume { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public bool? Roicalculation { get; set; }
    }
}
