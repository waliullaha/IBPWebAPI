using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Ppmaster
    {
        public Ppmaster()
        {
            Ppdetails = new HashSet<Ppdetail>();
            PpmasterAuthoUsers = new HashSet<PpmasterAuthoUser>();
        }

        public int Id { get; set; }
        public string ProposalCode { get; set; }
        public string ProjectName { get; set; }
        public int ForecastScenarioId { get; set; }
        public DateTime? SendDate { get; set; }
        public string Comments { get; set; }
        /// <summary>
        /// Entry-220,Submit-221,Verify-222,Agree-223,Authorize-224,Circulation-225
        /// </summary>
        public int StatusId { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ValueList Status { get; set; }
        public virtual ICollection<Ppdetail> Ppdetails { get; set; }
        public virtual ICollection<PpmasterAuthoUser> PpmasterAuthoUsers { get; set; }
    }
}
