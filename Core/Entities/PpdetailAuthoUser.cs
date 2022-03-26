using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class PpdetailAuthoUser
    {
        public PpdetailAuthoUser()
        {
            PpdetailQueries = new HashSet<PpdetailQuery>();
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public int PpmasterId { get; set; }
        public int UserId { get; set; }
        /// <summary>
        /// CAM-226,SAM-227
        /// </summary>
        public int ProcessType { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime? ProcessTime { get; set; }
        public string Comments { get; set; }
        public DateTime? SendTime { get; set; }
        public int TotalTime { get; set; }

        public virtual Ppdetail Parent { get; set; }
        public virtual ICollection<PpdetailQuery> PpdetailQueries { get; set; }
    }
}
