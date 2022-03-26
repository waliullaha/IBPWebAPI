using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AbsoaslabHistory
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Description { get; set; }
        public decimal MaxValue { get; set; }
        public decimal MinValue { get; set; }
    }
}
