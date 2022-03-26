using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class UserLimitModule
    {
        public int? FinancialLimitType { get; set; }
        public int Abtype { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
    }
}
