using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ProductGroupAuthoUser
    {
        public int Id { get; set; }
        public int ProductGroupId { get; set; }
        public int UserId { get; set; }
        public int ProcessType { get; set; }
        public int CompanyId { get; set; }

        public virtual ProductGroup ProductGroup { get; set; }
    }
}
