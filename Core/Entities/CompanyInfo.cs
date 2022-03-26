using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class CompanyInfo
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string CompanyCode { get; set; }
    }
}
