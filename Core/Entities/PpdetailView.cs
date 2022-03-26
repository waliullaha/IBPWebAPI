using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class PpdetailView
    {
        public string ProposalCode { get; set; }
        public string ProjectName { get; set; }
        public DateTime? SendDate { get; set; }
        public string SendDateFormatted { get; set; }
        public string EntryUserName { get; set; }
        public int? MasterStatusId { get; set; }
        public string MasterStatus { get; set; }
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Ph9code { get; set; }
        public string Ph9name { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime EffectiveDateTwo { get; set; }
        public string EffectiveDateFormatted { get; set; }
        public string EffectiveDateTwoFormatted { get; set; }
        public int DetailStatusId { get; set; }
        public string DetailStatus { get; set; }
    }
}
