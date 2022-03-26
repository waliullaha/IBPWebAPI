using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class LockedScenario
    {
        public int Id { get; set; }
        public int ScenarioId { get; set; }
        public int LockedYear { get; set; }
        public int LockedMonth { get; set; }
        public DateTime EntryDate { get; set; }
        public int EntryUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUserId { get; set; }
    }
}
