using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class UserLimit
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? ExpenditureId { get; set; }
        public decimal FinancialLimit { get; set; }
        public bool IsUnlimited { get; set; }
        public int FinancialLimitType { get; set; }
        public int Abtype { get; set; }
    }
}
