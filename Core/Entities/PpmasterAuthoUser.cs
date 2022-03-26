using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class PpmasterAuthoUser
    {
        public PpmasterAuthoUser()
        {
            PpmasterQueries = new HashSet<PpmasterQuery>();
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public int UserId { get; set; }
        /// <summary>
        /// Initiated-220,Submit-221,Agree-222,Approve-223,Authorize-224,Circulation-225
        /// </summary>
        public int ProcessType { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime? ProcessTime { get; set; }
        public string Comments { get; set; }
        public DateTime? SendTime { get; set; }
        public int TotalTime { get; set; }

        public virtual Ppmaster Parent { get; set; }
        public virtual ICollection<PpmasterQuery> PpmasterQueries { get; set; }
    }
}
