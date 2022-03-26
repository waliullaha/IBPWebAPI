using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ReportDetailFormula
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int? ItemId { get; set; }
        public int ItemType { get; set; }
        public string FormulaValue { get; set; }
        public int Position { get; set; }

        public virtual ReportDetail Parent { get; set; }
    }
}
