using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AbsoarmfundUser
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string GroupCode { get; set; }
        public int ApproverTypeId { get; set; }
        public int UserId { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }

        public virtual Absoamaster Parent { get; set; }
    }
}
