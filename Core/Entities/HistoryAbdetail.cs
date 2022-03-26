using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class HistoryAbdetail
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int ExpType { get; set; }
        public int TradeType { get; set; }
        public int Omquarter { get; set; }
        public int? SupplierId { get; set; }
        public int? ExpTypeId { get; set; }
        public int? RecomUserId { get; set; }
        public int? AgencyTypeId { get; set; }
        public int? TgtAudienceId { get; set; }
        public int? FirstLvlResearchTypeId { get; set; }
        public int? SecondLvlResearchTypeId { get; set; }
        public int? ThirdtLvlResearchTypeId { get; set; }
        public int? ForthLvlResearchTypeId { get; set; }
        public int? FifthLvlResearchTypeId { get; set; }
        public DateTime? AiringDate { get; set; }
        public DateTime? SampleRevDate { get; set; }
        public DateTime? StimulationRevDate { get; set; }
        public string CategoryCode { get; set; }
        public string Objective { get; set; }
        public string JobDescription { get; set; }
        public string MeasureCriteria { get; set; }
        public string Rotcriteria { get; set; }
        public string Rotrewards { get; set; }
        public string Background { get; set; }
        public string InfoProbScope { get; set; }
        public string Methodology { get; set; }
        public int? ActivityTypeId { get; set; }
        public int? OpsPlanId { get; set; }
        public int TotalBasket { get; set; }
        public decimal DiscountAmount { get; set; }
        public int ForecastScenarioId { get; set; }
        public int FinancialReturn { get; set; }
        public decimal ReachValue { get; set; }
        public decimal FrequencyValue { get; set; }
        public decimal Grpvalue { get; set; }
        public string ReachComments { get; set; }
        public string FrequencyComments { get; set; }
        public string Grpcomments { get; set; }
        public DateTime? FirstSendDate { get; set; }

        public virtual HistoryAbmaster Parent { get; set; }
    }
}
