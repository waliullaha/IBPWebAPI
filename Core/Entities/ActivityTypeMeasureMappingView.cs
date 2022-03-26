using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ActivityTypeMeasureMappingView
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int ValueType { get; set; }
        public string ValueTypeDescription { get; set; }
        public int Position { get; set; }
        public int? MeasureId { get; set; }
        public int? LocationId { get; set; }
        public string LocationCode { get; set; }
        public string MeasureCode { get; set; }
        public string MeasureDescription { get; set; }
    }
}
