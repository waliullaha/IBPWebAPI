using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimDidistributorGroupView
    {
        public int Id { get; set; }
        public int GradeId { get; set; }
        public int GroupId { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string Grade { get; set; }
        public string Groups { get; set; }
        public string GradeGroup { get; set; }
    }
}
