using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class CmsalaryStructureView
    {
        public int Id { get; set; }
        public int GradeId { get; set; }
        public int CategoryId { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Ta { get; set; }
        public decimal Da { get; set; }
        public decimal Hopi { get; set; }
        public decimal Lopi { get; set; }
        public decimal Bonus { get; set; }
        public DateTime EffectDate { get; set; }
        public DateTime? TillDate { get; set; }
        public string Grade { get; set; }
        public string Category { get; set; }
        public string GradeCategory { get; set; }
    }
}
