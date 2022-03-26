using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Abtvc
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int Tvcid { get; set; }
        public string Ph8code { get; set; }

        public virtual Abmaster Parent { get; set; }
    }
}
