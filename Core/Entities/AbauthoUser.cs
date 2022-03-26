using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AbauthoUser
    {
        public AbauthoUser()
        {
            Abqueries = new HashSet<Abquery>();
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public int UserId { get; set; }
        public int ProcessType { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime ProcessTime { get; set; }
        public string Comments { get; set; }
        public int? AmendNo { get; set; }
        public DateTime? SendTime { get; set; }
        public int TotalTime { get; set; }
        public bool? IsRetrospective { get; set; }

        public virtual Abmaster Parent { get; set; }
        public virtual ICollection<Abquery> Abqueries { get; set; }
    }
}
