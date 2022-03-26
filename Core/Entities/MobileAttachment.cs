using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class MobileAttachment
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string FileName { get; set; }
        public string Location { get; set; }
    }
}
