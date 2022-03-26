using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimClarificationHistoryView
    {
        public int Id { get; set; }
        public int ClaimMasterId { get; set; }
        public string FromEmployee { get; set; }
        public int FromEmployeeId { get; set; }
        public int FromUserTypeId { get; set; }
        public string FromUserComments { get; set; }
        public bool IsSend { get; set; }
        public DateTime SendDate { get; set; }
        public string ToEmployee { get; set; }
        public int ToEmployeeId { get; set; }
        public int ToUserTypeId { get; set; }
        public string ToUserComments { get; set; }
        public bool IsReplay { get; set; }
        public DateTime? ReplayDate { get; set; }
        public DateTime EntryDate { get; set; }
        public string FromUserType { get; set; }
        public string ToUserType { get; set; }
        public string Send { get; set; }
        public string Replay { get; set; }
        public string SendDateFormatted { get; set; }
        public string ReplayDateFormatted { get; set; }
    }
}
