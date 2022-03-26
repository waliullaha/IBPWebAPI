using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class DigradeGroupView
    {
        public int GradeGroupId { get; set; }
        public int GradeId { get; set; }
        public int GroupId { get; set; }
        public string Grade { get; set; }
        public string Group { get; set; }
        public int? Town { get; set; }
    }
}
