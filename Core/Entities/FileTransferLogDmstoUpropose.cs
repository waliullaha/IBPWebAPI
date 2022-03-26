using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class FileTransferLogDmstoUpropose
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public DateTime? Date { get; set; }
        public bool? Status { get; set; }
    }
}
