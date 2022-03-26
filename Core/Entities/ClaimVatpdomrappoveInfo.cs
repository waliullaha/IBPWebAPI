using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimVatpdomrappoveInfo
    {
        public int Id { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }
        public int CalimType { get; set; }
        public int BatchNo { get; set; }
        public string BatchDetail { get; set; }
        public string Comments { get; set; }
        public DateTime EntryDate { get; set; }
        public int BatchStatusId { get; set; }
        public int UserTypeId { get; set; }
        public string SystemComments { get; set; }
    }
}
