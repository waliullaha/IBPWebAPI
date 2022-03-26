using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class PomustSku
    {
        public int Id { get; set; }
        public string GrocerType { get; set; }
        public string Sku { get; set; }
        public int GrocerTypeId { get; set; }
    }
}
