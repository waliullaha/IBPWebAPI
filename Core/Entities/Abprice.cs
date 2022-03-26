using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Abprice
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Ph9code { get; set; }
        public decimal ActualRsp { get; set; }
        public decimal ActualGm { get; set; }
        public decimal ActualTm { get; set; }
        public decimal ForecastRsp { get; set; }
        public decimal ForecastGm { get; set; }
        public decimal ForecastTm { get; set; }
        public decimal CompetitorRsp { get; set; }
        public decimal CompetitorTm { get; set; }
        public decimal JanuaryVolume { get; set; }
        public decimal FebruaryVolume { get; set; }
        public decimal MarchVolume { get; set; }
        public decimal AprilVolume { get; set; }
        public decimal MayVolume { get; set; }
        public decimal JuneVolume { get; set; }
        public decimal JulyVolume { get; set; }
        public decimal AugustVolume { get; set; }
        public decimal SeptemberVolume { get; set; }
        public decimal OctoberVolume { get; set; }
        public decimal NovemberVolume { get; set; }
        public decimal DecemberVolume { get; set; }
        public decimal JanuaryTurnover { get; set; }
        public decimal FebruaryTurnover { get; set; }
        public decimal MarchTurnover { get; set; }
        public decimal AprilTurnover { get; set; }
        public decimal MayTurnover { get; set; }
        public decimal JuneTurnover { get; set; }
        public decimal JulyTurnover { get; set; }
        public decimal AugustTurnover { get; set; }
        public decimal SeptemberTurnover { get; set; }
        public decimal OctoberTurnover { get; set; }
        public decimal NovemberTurnover { get; set; }
        public decimal DecemberTurnover { get; set; }
        public decimal JanuaryGp { get; set; }
        public decimal FebruaryGp { get; set; }
        public decimal MarchGp { get; set; }
        public decimal AprilGp { get; set; }
        public decimal MayGp { get; set; }
        public decimal JuneGp { get; set; }
        public decimal JulyGp { get; set; }
        public decimal AugustGp { get; set; }
        public decimal SeptemberGp { get; set; }
        public decimal OctoberGp { get; set; }
        public decimal NovemberGp { get; set; }
        public decimal DecemberGp { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime LastPriceChangeDate { get; set; }
        public decimal FbcoptionOne { get; set; }
        public decimal FbcoptionTwo { get; set; }
        public decimal FbcoptionThree { get; set; }
        public decimal FbcoptionFour { get; set; }
        public decimal DmoptionOne { get; set; }
        public decimal DmoptionTwo { get; set; }
        public decimal DmoptionThree { get; set; }
        public decimal DmoptionFour { get; set; }
        public decimal TmoptionOne { get; set; }
        public decimal TmoptionTwo { get; set; }
        public decimal TmoptionThree { get; set; }
        public decimal TmoptionFour { get; set; }
        public decimal DvpoptionOne { get; set; }
        public decimal DvpoptionTwo { get; set; }
        public decimal DvpoptionThree { get; set; }
        public decimal DvpoptionFour { get; set; }
        public decimal DvoptionOne { get; set; }
        public decimal DvoptionTwo { get; set; }
        public decimal DvoptionThree { get; set; }
        public decimal DvoptionFour { get; set; }
        public decimal DozonOptionOne { get; set; }
        public decimal DozonOptionTwo { get; set; }
        public decimal DozonOptionThree { get; set; }
        public decimal DozonOptionFour { get; set; }
        public decimal UnitOptionOne { get; set; }
        public decimal UnitOptionTwo { get; set; }
        public decimal UnitOptionThree { get; set; }
        public decimal UnitOptionFour { get; set; }

        public virtual Abmaster Parent { get; set; }
    }
}
