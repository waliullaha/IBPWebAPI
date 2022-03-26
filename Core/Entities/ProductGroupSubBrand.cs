using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ProductGroupSubBrand
    {
        public int Id { get; set; }
        public string Ph8code { get; set; }
        public int ProductGroupId { get; set; }
        public int CompanyId { get; set; }

        public virtual ProductGroup ProductGroup { get; set; }
    }
}
