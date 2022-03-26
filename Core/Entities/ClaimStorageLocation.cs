using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimStorageLocation
    {
        public int Id { get; set; }
        public string OrderReason { get; set; }
        public string StorageLocation { get; set; }
    }
}
