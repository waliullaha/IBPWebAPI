using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class SoaTemp
    {
        public string GroupCode { get; set; }
        public string Abtype { get; set; }
        public string ActivityType { get; set; }
        public string HierarchyLevel { get; set; }
        public string Rmfund { get; set; }
        public string NegativeRoi { get; set; }
        public string Retrospective { get; set; }
        public string Sku { get; set; }
        public string SlabDescription { get; set; }
        public string SlabMaxValue { get; set; }
        public string AgreeUsers { get; set; }
        public string ApproveUsers { get; set; }
        public string AuthorizeUsers { get; set; }
    }
}
