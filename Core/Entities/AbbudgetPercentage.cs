using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AbbudgetPercentage
    {
        public int Id { get; set; }
        public int Abid { get; set; }
        public DateTime ActivityStartDate { get; set; }
        public decimal BudgetPercentage { get; set; }
        public DateTime EffectiveDate { get; set; }

        public virtual Abmaster Ab { get; set; }
    }
}
