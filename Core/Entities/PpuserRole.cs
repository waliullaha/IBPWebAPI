using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class PpuserRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsBm { get; set; }
        public bool IsCam { get; set; }
        public bool IsSam { get; set; }
        public bool IsTcm { get; set; }
        public bool IsCfm { get; set; }
        public bool IsBbd { get; set; }
        public bool IsCdd { get; set; }
        public bool IsScd { get; set; }
        public bool IsFd { get; set; }
        public bool IsCoo { get; set; }
        public bool IsMd { get; set; }
        public bool IsAdministrator { get; set; }
        public bool IsPpa { get; set; }
    }
}
