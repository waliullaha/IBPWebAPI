using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Rejection
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int UserId { get; set; }
        public DateTime ExecutionDate { get; set; }
        public string Comments { get; set; }
    }
}
