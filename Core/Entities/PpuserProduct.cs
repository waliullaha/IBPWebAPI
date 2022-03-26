using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class PpuserProduct
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Ph8code { get; set; }

        public virtual ValueList Role { get; set; }
    }
}
