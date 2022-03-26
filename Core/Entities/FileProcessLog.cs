using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class FileProcessLog
    {
        public int Id { get; set; }
        public int FileId { get; set; }
        public string FileName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Message { get; set; }
    }
}
