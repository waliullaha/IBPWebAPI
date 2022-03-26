using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ReportDetail
    {
        public ReportDetail()
        {
            ReportDetailFormulas = new HashSet<ReportDetailFormula>();
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public int? MeasureId { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }
        public bool FontBold { get; set; }
        public bool FontItalic { get; set; }
        public bool FontUnderLine { get; set; }
        public string FontBackColor { get; set; }
        public string FontForeColor { get; set; }
        public bool BlankRow { get; set; }
        public bool LineRow { get; set; }
        public int LeftMargin { get; set; }
        public decimal BlankRowHeight { get; set; }
        public int NoOfBlankRow { get; set; }
        public int Position { get; set; }
        public int? ExcelRowNumber { get; set; }
        public string ExcelEquation { get; set; }
        public string EquationName { get; set; }
        public bool? IsFormula { get; set; }
        public string Equation { get; set; }
        public bool IsUpguvg { get; set; }

        public virtual ReportMaster Parent { get; set; }
        public virtual ICollection<ReportDetailFormula> ReportDetailFormulas { get; set; }
    }
}
