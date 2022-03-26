using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AbqueryView
    {
        public int QueryId { get; set; }
        public int Abid { get; set; }
        public int ParentId { get; set; }
        public int QueryUserId { get; set; }
        public string QueryUser { get; set; }
        public string QueryUserDetail { get; set; }
        public string QueryText { get; set; }
        public DateTime QueryDate { get; set; }
        public string QueryDateFormatted { get; set; }
        public int ProcessType { get; set; }
        public int? ReplyId { get; set; }
        public int? ReplyUserId { get; set; }
        public string ReplyUser { get; set; }
        public string ReplyUserDetail { get; set; }
        public string ReplyText { get; set; }
        public DateTime? ReplyDate { get; set; }
        public string ReplyDateFormatted { get; set; }
        public bool? IsReplied { get; set; }
        public string Replied { get; set; }
        public int Id { get; set; }
    }
}
