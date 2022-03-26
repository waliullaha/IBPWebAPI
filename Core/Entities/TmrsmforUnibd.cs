using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class TmrsmforUnibd
    {
        public int DistributorId { get; set; }
        public string DistributorCode { get; set; }
        public string Sapcode { get; set; }
        public int Tm { get; set; }
        public string Tmname { get; set; }
        public string Rsm { get; set; }
        public string Rsmname { get; set; }
    }
}
