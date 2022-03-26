﻿using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AbmasterView1
    {
        public int Id { get; set; }
        public int Abtype { get; set; }
        public int AbslNo { get; set; }
        public string Abnumber { get; set; }
        public string Description { get; set; }
        public DateTime? Abdate { get; set; }
        public DateTime ClosureDate { get; set; }
        public DateTime ApprovalDate { get; set; }
        public DateTime ActivityStartDate { get; set; }
        public DateTime ActivityEndDate { get; set; }
        public string Abdetails { get; set; }
        public decimal Abamount { get; set; }
        public decimal Npiamount { get; set; }
        public decimal ClaimAmount { get; set; }
        public int SystemType { get; set; }
        public int InvoiceDiscountType { get; set; }
        public string ProfitCenter { get; set; }
        public string ChargeAccount { get; set; }
        public string ProvisionAccount { get; set; }
        public string PaymentAccount { get; set; }
        public bool IsAgreed { get; set; }
        public bool IsApproved { get; set; }
        public bool IsAuthorised { get; set; }
        public bool IsSend { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsAmended { get; set; }
        public int AmendTimes { get; set; }
        public bool IsFdconsult { get; set; }
        public int? ClaimTypeId { get; set; }
        public bool IsBudgeted { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? ActionDate { get; set; }
        public int DetailId { get; set; }
        public int ExpType { get; set; }
        public int TradeType { get; set; }
        public int Omquarter { get; set; }
        public int? SupplierId { get; set; }
        public int? ExpTypeId { get; set; }
        public int? RecomUserId { get; set; }
        public int? ActivityTypeId { get; set; }
        public int? OpsPlanId { get; set; }
        public int? AgencyTypeId { get; set; }
        public string OmquarterText { get; set; }
        public int? TgtAudienceId { get; set; }
        public int? FirstLvlResearchTypeId { get; set; }
        public int? SecondLvlResearchTypeId { get; set; }
        public int? ThirdtLvlResearchTypeId { get; set; }
        public int? ForthLvlResearchTypeId { get; set; }
        public int? FifthLvlResearchTypeId { get; set; }
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
        public DateTime? AiringDate { get; set; }
        public string EstimatedRoi { get; set; }
        public decimal AmendValue { get; set; }
        public string Abnumbers { get; set; }
        public decimal AmendAmount { get; set; }
        public string Module { get; set; }
        public string ClaimType { get; set; }
        public string ActivityType { get; set; }
        public string RefNo { get; set; }
        public string Eh4name { get; set; }
        public string SupplierName { get; set; }
        public string RecommendUser { get; set; }
        public string FirstDescription { get; set; }
        public string SecondDescription { get; set; }
        public string ThirdtDescription { get; set; }
        public string ForthDescription { get; set; }
        public string FifthDescription { get; set; }
        public string TargetAudience { get; set; }
        public int Mbid { get; set; }
        public string BriefNo { get; set; }
        public int Ibid { get; set; }
        public string Ibno { get; set; }
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool? IsActive { get; set; }
        public string AbamountMillionFormat { get; set; }
        public string NpiamountMillionFormat { get; set; }
        public string ClaimAmountMillionFormat { get; set; }
        public decimal? Abamount1 { get; set; }
        public string Send { get; set; }
        public string Agreed { get; set; }
        public string Approved { get; set; }
        public string Authorized { get; set; }
        public string StatusText { get; set; }
        public string ErrorMessage { get; set; }
        public string StartDateFormatted { get; set; }
        public string EndDateFormatted { get; set; }
        public string AbdateFormatted { get; set; }
        public string ClosureDateFormatted { get; set; }
        public string ApprovalDateFormatted { get; set; }
        public string EntryDateFormatted { get; set; }
        public string UpdateDateFormatted { get; set; }
        public string AiringDateFormatted { get; set; }
        public string InvoiceDiscount { get; set; }
        public string AbstartDate { get; set; }
        public string AbendDate { get; set; }
        public int? FromMonth { get; set; }
        public int? ToMonth { get; set; }
        public string PendingAbusers { get; set; }
        public string AbmonthYearText { get; set; }
    }
}
