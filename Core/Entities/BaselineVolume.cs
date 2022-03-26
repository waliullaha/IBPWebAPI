using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class BaselineVolume
    {
        public int Id { get; set; }
        public int BaselineYear { get; set; }
        public string Ph9code { get; set; }
        public string Ph9name { get; set; }
        public decimal January { get; set; }
        public decimal February { get; set; }
        public decimal March { get; set; }
        public decimal April { get; set; }
        public decimal May { get; set; }
        public decimal June { get; set; }
        public decimal July { get; set; }
        public decimal August { get; set; }
        public decimal September { get; set; }
        public decimal October { get; set; }
        public decimal November { get; set; }
        public decimal December { get; set; }
    }
}
