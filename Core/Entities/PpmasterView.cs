using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class PpmasterView
    {
        public int Id { get; set; }
        public string ProposalCode { get; set; }
        public string ProjectName { get; set; }
        public int ForecastScenarioId { get; set; }
        public DateTime? SendDate { get; set; }
        public string Comments { get; set; }
        public int StatusId { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string SendDateFormatted { get; set; }
        public string Status { get; set; }
        public string StatusDetail { get; set; }
        public string EntryDateFormatted { get; set; }
        public string UpdateDateFormatted { get; set; }
        public string EntryUserLoginId { get; set; }
        public string EntryUserName { get; set; }
        public string UpdateUserLoginId { get; set; }
        public string UpdateUserName { get; set; }
        public string PendingUsers { get; set; }
    }
}
