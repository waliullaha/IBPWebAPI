using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimComment
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Comments { get; set; }
        public DateTime CommentsDate { get; set; }
        public int EntryUserId { get; set; }
    }
}
