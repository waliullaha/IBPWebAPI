using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Smsmaster
    {
        public int Id { get; set; }
        public string KeyCode { get; set; }
        public string ValueText { get; set; }
    }
}
