using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ProductGroup
    {
        public ProductGroup()
        {
            ProductGroupAuthoUsers = new HashSet<ProductGroupAuthoUser>();
            ProductGroupSubBrands = new HashSet<ProductGroupSubBrand>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }

        public virtual ICollection<ProductGroupAuthoUser> ProductGroupAuthoUsers { get; set; }
        public virtual ICollection<ProductGroupSubBrand> ProductGroupSubBrands { get; set; }
    }
}
