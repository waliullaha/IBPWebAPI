using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Abrejection
    {
        public int Id { get; set; }
        public int Idvalue { get; set; }
        public int UserId { get; set; }
        public int ObjectType { get; set; }
        public DateTime ExecutionDate { get; set; }
        public string Comments { get; set; }
    }
}
