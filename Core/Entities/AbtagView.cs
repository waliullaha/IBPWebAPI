using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AbtagView
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Acode { get; set; }
        public string Description { get; set; }
        public int ValueType { get; set; }
        public string ValueTypeDescription { get; set; }
        public int ClaimTypeId { get; set; }
        public int AbmoduleId { get; set; }
        public int ModuleId { get; set; }
        public string FullName { get; set; }
    }
}
