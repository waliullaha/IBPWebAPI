using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AbdeleteAuthorization
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int RequestUserId { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestText { get; set; }
        public int AuthoriseUserId { get; set; }
        public DateTime? AuthoriseDate { get; set; }
        public string AuthoriseText { get; set; }
        public int StatusId { get; set; }

        public virtual Abmaster Parent { get; set; }
    }
}
