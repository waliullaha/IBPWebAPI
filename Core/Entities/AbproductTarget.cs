using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AbproductTarget
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int Jcid { get; set; }
        public int Abid { get; set; }
        public decimal TargetVolume { get; set; }
        public decimal ActualVolume { get; set; }
    }
}
