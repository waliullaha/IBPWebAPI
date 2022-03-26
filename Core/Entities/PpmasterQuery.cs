using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class PpmasterQuery
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int PpmasterId { get; set; }
        public int QueryUserId { get; set; }
        public DateTime QueryDate { get; set; }
        public string QueryText { get; set; }
        public int ReplyUserId { get; set; }
        public DateTime? ReplyDate { get; set; }
        public string ReplyText { get; set; }
        public bool IsReplied { get; set; }

        public virtual PpmasterAuthoUser Parent { get; set; }
    }
}
