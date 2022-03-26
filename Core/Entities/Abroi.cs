using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Abroi
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int ActualScenarioId { get; set; }
        public int ForecastScenarioId { get; set; }
        public int PromoStartPeriod { get; set; }
        public int PromoEndPeriod { get; set; }
        public int PostPromoPeriod { get; set; }
        public decimal PreBaseVolume { get; set; }
        public decimal PostBaseVolume { get; set; }
        public decimal PrePlanVolume { get; set; }
        public decimal PostPlanVolume { get; set; }
        public decimal PlanAchievement { get; set; }
        public decimal PreIncrementalVolume { get; set; }
        public decimal PostIncrementalVolume { get; set; }
        public decimal IncrementalVolumeAchievement { get; set; }
        public decimal PreIncrementalGp { get; set; }
        public decimal PostIncrementalGp { get; set; }
        public decimal IncrementalGpachievement { get; set; }
        public decimal PrePromoCost { get; set; }
        public decimal PostPromoCost { get; set; }
        public decimal PromoCostAchievement { get; set; }
        public decimal PreOtherPromoCost { get; set; }
        public decimal PostOtherPromoCost { get; set; }
        public decimal PreTotalInvestment { get; set; }
        public decimal PostTotalInvestment { get; set; }
        public decimal TotalInvestmentAchievement { get; set; }
        public decimal PreRoi { get; set; }
        public decimal PostRoi { get; set; }
        public decimal Roiachievement { get; set; }
        public string NegativeRoijustification { get; set; }
        public string PostNegativeRoijustification { get; set; }
        public string OtherPreCostJustification { get; set; }
        public string OtherPostCostJustification { get; set; }
        public bool IsPostMonth { get; set; }

        public virtual Abmaster Parent { get; set; }
    }
}
