using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class UpdatedProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? Rate { get; set; }
    }
}
