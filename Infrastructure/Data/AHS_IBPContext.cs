using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Core.Entities;

namespace Infrastructure.Data
{
    public partial class AHS_IBPContext : DbContext
    {
        public AHS_IBPContext()
        {
        }

        public AHS_IBPContext(DbContextOptions<AHS_IBPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbactionLog> AbactionLogs { get; set; }
        public virtual DbSet<Abamend> Abamends { get; set; }
        public virtual DbSet<AbauthoUser> AbauthoUsers { get; set; }
        public virtual DbSet<AbauthoUserAmend> AbauthoUserAmends { get; set; }
        public virtual DbSet<AbauthorizerMail> AbauthorizerMails { get; set; }
        public virtual DbSet<AbbudgetPercentage> AbbudgetPercentages { get; set; }
        public virtual DbSet<Abchannel> Abchannels { get; set; }
        public virtual DbSet<Abcost> Abcosts { get; set; }
        public virtual DbSet<AbdataView> AbdataViews { get; set; }
        public virtual DbSet<Abdatum> Abdata { get; set; }
        public virtual DbSet<AbdeleteAuthorization> AbdeleteAuthorizations { get; set; }
        public virtual DbSet<Abdetail> Abdetails { get; set; }
        public virtual DbSet<Abevcost> Abevcosts { get; set; }
        public virtual DbSet<AbkeyAccount> AbkeyAccounts { get; set; }
        public virtual DbSet<Abmaster> Abmasters { get; set; }
        public virtual DbSet<Abmaster1> Abmasters1 { get; set; }
        public virtual DbSet<AbmasterView> AbmasterViews { get; set; }
        public virtual DbSet<AbmasterView1> AbmasterView1s { get; set; }
        public virtual DbSet<Abmrsupplier> Abmrsuppliers { get; set; }
        public virtual DbSet<AbpendingView> AbpendingViews { get; set; }
        public virtual DbSet<Abprice> Abprices { get; set; }
        public virtual DbSet<AbpriceProposalView> AbpriceProposalViews { get; set; }
        public virtual DbSet<Abproduct> Abproducts { get; set; }
        public virtual DbSet<Abproduct1> Abproduct1s { get; set; }
        public virtual DbSet<AbproductChannel> AbproductChannels { get; set; }
        public virtual DbSet<AbproductTarget> AbproductTargets { get; set; }
        public virtual DbSet<Abquery> Abqueries { get; set; }
        public virtual DbSet<AbqueryView> AbqueryViews { get; set; }
        public virtual DbSet<Abrejection> Abrejections { get; set; }
        public virtual DbSet<Abroi> Abrois { get; set; }
        public virtual DbSet<Abroidatum> Abroidata { get; set; }
        public virtual DbSet<Absapio> Absapios { get; set; }
        public virtual DbSet<Absapiochannel> Absapiochannels { get; set; }
        public virtual DbSet<AbslabUser> AbslabUsers { get; set; }
        public virtual DbSet<AbslabUserHistory> AbslabUserHistories { get; set; }
        public virtual DbSet<Absoamaster> Absoamasters { get; set; }
        public virtual DbSet<AbsoamasterHistory> AbsoamasterHistories { get; set; }
        public virtual DbSet<AbsoanegativeRoi> AbsoanegativeRois { get; set; }
        public virtual DbSet<AbsoanegativeRoihistory> AbsoanegativeRoihistories { get; set; }
        public virtual DbSet<Absoaproduct> Absoaproducts { get; set; }
        public virtual DbSet<AbsoaproductHistory> AbsoaproductHistories { get; set; }
        public virtual DbSet<AbsoaretrospectiveUser> AbsoaretrospectiveUsers { get; set; }
        public virtual DbSet<AbsoaretrospectiveUsersHistory> AbsoaretrospectiveUsersHistories { get; set; }
        public virtual DbSet<AbsoarmfundUser> AbsoarmfundUsers { get; set; }
        public virtual DbSet<AbsoarmfundUserHistory> AbsoarmfundUserHistories { get; set; }
        public virtual DbSet<Absoaslab> Absoaslabs { get; set; }
        public virtual DbSet<AbsoaslabHistory> AbsoaslabHistories { get; set; }
        public virtual DbSet<AbtagView> AbtagViews { get; set; }
        public virtual DbSet<Abtvc> Abtvcs { get; set; }
        public virtual DbSet<ActionQue> ActionQues { get; set; }
        public virtual DbSet<ActivityTypeMeasureMappingView> ActivityTypeMeasureMappingViews { get; set; }
        public virtual DbSet<AhsAllClaimDetail> AhsAllClaimDetails { get; set; }
        public virtual DbSet<AhsAllClaimMaster> AhsAllClaimMasters { get; set; }
        public virtual DbSet<AhsClaimType> AhsClaimTypes { get; set; }
        public virtual DbSet<AhsMailSendToDistributor> AhsMailSendToDistributors { get; set; }
        public virtual DbSet<AhsSapAccrual> AhsSapAccruals { get; set; }
        public virtual DbSet<AhsSapControlTable> AhsSapControlTables { get; set; }
        public virtual DbSet<AhsSapCreditNote> AhsSapCreditNotes { get; set; }
        public virtual DbSet<AhsSapCreditNoteAdjustmentDetail> AhsSapCreditNoteAdjustmentDetails { get; set; }
        public virtual DbSet<AhsSapCreditNoteAdjustmentMaster> AhsSapCreditNoteAdjustmentMasters { get; set; }
        public virtual DbSet<AhsSapIomaster> AhsSapIomasters { get; set; }
        public virtual DbSet<AhsSapIoplan> AhsSapIoplans { get; set; }
        public virtual DbSet<AhsSapWeeklySecondarySale> AhsSapWeeklySecondarySales { get; set; }
        public virtual DbSet<AhsUser> AhsUsers { get; set; }
        public virtual DbSet<AhsUserNew> AhsUserNews { get; set; }
        public virtual DbSet<AhsWf> AhsWfs { get; set; }
        public virtual DbSet<Aitcbt> Aitcbts { get; set; }
        public virtual DbSet<ArchiveClaimClp> ArchiveClaimClps { get; set; }
        public virtual DbSet<ArchiveClaimCoupon> ArchiveClaimCoupons { get; set; }
        public virtual DbSet<ArchiveClaimDamage> ArchiveClaimDamages { get; set; }
        public virtual DbSet<ArchiveClaimDd> ArchiveClaimDds { get; set; }
        public virtual DbSet<ArchiveClaimDff> ArchiveClaimDffs { get; set; }
        public virtual DbSet<ArchiveClaimDosti> ArchiveClaimDostis { get; set; }
        public virtual DbSet<ArchiveClaimManual> ArchiveClaimManuals { get; set; }
        public virtual DbSet<ArchiveClaimMaster> ArchiveClaimMasters { get; set; }
        public virtual DbSet<ArchiveClaimNsddetail> ArchiveClaimNsddetails { get; set; }
        public virtual DbSet<ArchiveClaimP> ArchiveClaimPs { get; set; }
        public virtual DbSet<ArchiveClaimPollydut> ArchiveClaimPollyduts { get; set; }
        public virtual DbSet<ArchiveClaimSendAsm> ArchiveClaimSendAsms { get; set; }
        public virtual DbSet<AuthorizationUser> AuthorizationUsers { get; set; }
        public virtual DbSet<AuthorizedAbdelete> AuthorizedAbdeletes { get; set; }
        public virtual DbSet<AuthorizedAbview> AuthorizedAbviews { get; set; }
        public virtual DbSet<AvailibilityComplainView> AvailibilityComplainViews { get; set; }
        public virtual DbSet<BaselineVolume> BaselineVolumes { get; set; }
        public virtual DbSet<BudgetRatio> BudgetRatios { get; set; }
        public virtual DbSet<BudgetRatioBmilocal> BudgetRatioBmilocals { get; set; }
        public virtual DbSet<CcandGlaccountView> CcandGlaccountViews { get; set; }
        public virtual DbSet<Channel> Channels { get; set; }
        public virtual DbSet<ClaimAit> ClaimAits { get; set; }
        public virtual DbSet<ClaimAitprocessDay> ClaimAitprocessDays { get; set; }
        public virtual DbSet<ClaimAitview> ClaimAitviews { get; set; }
        public virtual DbSet<ClaimAllocationRule> ClaimAllocationRules { get; set; }
        public virtual DbSet<ClaimAutoBatchCreationView> ClaimAutoBatchCreationViews { get; set; }
        public virtual DbSet<ClaimBacklitRate> ClaimBacklitRates { get; set; }
        public virtual DbSet<ClaimBacklitTarget> ClaimBacklitTargets { get; set; }
        public virtual DbSet<ClaimBacklitTargetDataView> ClaimBacklitTargetDataViews { get; set; }
        public virtual DbSet<ClaimBudget> ClaimBudgets { get; set; }
        public virtual DbSet<ClaimBudgetNoAb> ClaimBudgetNoAbs { get; set; }
        public virtual DbSet<ClaimBudgetView> ClaimBudgetViews { get; set; }
        public virtual DbSet<ClaimCategoryView> ClaimCategoryViews { get; set; }
        public virtual DbSet<ClaimCategoryWiseClaimType> ClaimCategoryWiseClaimTypes { get; set; }
        public virtual DbSet<ClaimCdfmdatum> ClaimCdfmdata { get; set; }
        public virtual DbSet<ClaimClarificationHistory> ClaimClarificationHistories { get; set; }
        public virtual DbSet<ClaimClarificationHistoryView> ClaimClarificationHistoryViews { get; set; }
        public virtual DbSet<ClaimClp> ClaimClps { get; set; }
        public virtual DbSet<ClaimClpview> ClaimClpviews { get; set; }
        public virtual DbSet<ClaimCmdistributorEmployee> ClaimCmdistributorEmployees { get; set; }
        public virtual DbSet<ClaimCmgradeCategory> ClaimCmgradeCategories { get; set; }
        public virtual DbSet<ClaimCmhopidatum> ClaimCmhopidata { get; set; }
        public virtual DbSet<ClaimCmhopisetup> ClaimCmhopisetups { get; set; }
        public virtual DbSet<ClaimCmlopidatum> ClaimCmlopidata { get; set; }
        public virtual DbSet<ClaimCmsalary> ClaimCmsalaries { get; set; }
        public virtual DbSet<ClaimCmsalaryStructure> ClaimCmsalaryStructures { get; set; }
        public virtual DbSet<ClaimComment> ClaimComments { get; set; }
        public virtual DbSet<ClaimCostCenter> ClaimCostCenters { get; set; }
        public virtual DbSet<ClaimCoupon> ClaimCoupons { get; set; }
        public virtual DbSet<ClaimCouponView> ClaimCouponViews { get; set; }
        public virtual DbSet<ClaimCpp> ClaimCpps { get; set; }
        public virtual DbSet<ClaimDamage> ClaimDamages { get; set; }
        public virtual DbSet<ClaimDamageClarificationHistory> ClaimDamageClarificationHistories { get; set; }
        public virtual DbSet<ClaimDamageNsd> ClaimDamageNsds { get; set; }
        public virtual DbSet<ClaimDamageOmr> ClaimDamageOmrs { get; set; }
        public virtual DbSet<ClaimDamageOmrarchive> ClaimDamageOmrarchives { get; set; }
        public virtual DbSet<ClaimDamageReason> ClaimDamageReasons { get; set; }
        public virtual DbSet<ClaimDamageView> ClaimDamageViews { get; set; }
        public virtual DbSet<ClaimDd> ClaimDds { get; set; }
        public virtual DbSet<ClaimDdview> ClaimDdviews { get; set; }
        public virtual DbSet<ClaimDepotMapping> ClaimDepotMappings { get; set; }
        public virtual DbSet<ClaimDff> ClaimDffs { get; set; }
        public virtual DbSet<ClaimDffview> ClaimDffviews { get; set; }
        public virtual DbSet<ClaimDi> ClaimDis { get; set; }
        public virtual DbSet<ClaimDidistributorGroup> ClaimDidistributorGroups { get; set; }
        public virtual DbSet<ClaimDidistributorGroupView> ClaimDidistributorGroupViews { get; set; }
        public virtual DbSet<ClaimDidistributorPscomplaince> ClaimDidistributorPscomplainces { get; set; }
        public virtual DbSet<ClaimDidistributorPstarget> ClaimDidistributorPstargets { get; set; }
        public virtual DbSet<ClaimDidistributorSkutarget> ClaimDidistributorSkutargets { get; set; }
        public virtual DbSet<ClaimDidistributorTarget> ClaimDidistributorTargets { get; set; }
        public virtual DbSet<ClaimDigradeGroup> ClaimDigradeGroups { get; set; }
        public virtual DbSet<ClaimDiincentiveSetup> ClaimDiincentiveSetups { get; set; }
        public virtual DbSet<ClaimDiparamMaster> ClaimDiparamMasters { get; set; }
        public virtual DbSet<ClaimDiparamMasterView> ClaimDiparamMasterViews { get; set; }
        public virtual DbSet<ClaimDiparamPh> ClaimDiparamPhs { get; set; }
        public virtual DbSet<ClaimDiparamSc> ClaimDiparamScs { get; set; }
        public virtual DbSet<ClaimDiparamSlab> ClaimDiparamSlabs { get; set; }
        public virtual DbSet<ClaimDiprimarySalesMonthly> ClaimDiprimarySalesMonthlies { get; set; }
        public virtual DbSet<ClaimDiprocessDatum> ClaimDiprocessData { get; set; }
        public virtual DbSet<ClaimDisecondarySalesMonthly> ClaimDisecondarySalesMonthlies { get; set; }
        public virtual DbSet<ClaimDistributorPlant> ClaimDistributorPlants { get; set; }
        public virtual DbSet<ClaimDosti> ClaimDostis { get; set; }
        public virtual DbSet<ClaimDostiView> ClaimDostiViews { get; set; }
        public virtual DbSet<ClaimErrorLog> ClaimErrorLogs { get; set; }
        public virtual DbSet<ClaimErrorLogView> ClaimErrorLogViews { get; set; }
        public virtual DbSet<ClaimJvddicollection> ClaimJvddicollections { get; set; }
        public virtual DbSet<ClaimJvpayment> ClaimJvpayments { get; set; }
        public virtual DbSet<ClaimManual> ClaimManuals { get; set; }
        public virtual DbSet<ClaimManualAit> ClaimManualAits { get; set; }
        public virtual DbSet<ClaimManualBatchPendingView> ClaimManualBatchPendingViews { get; set; }
        public virtual DbSet<ClaimManualMaster> ClaimManualMasters { get; set; }
        public virtual DbSet<ClaimManualView> ClaimManualViews { get; set; }
        public virtual DbSet<ClaimManualold> ClaimManualolds { get; set; }
        public virtual DbSet<ClaimMaster> ClaimMasters { get; set; }
        public virtual DbSet<ClaimMasterView> ClaimMasterViews { get; set; }
        public virtual DbSet<ClaimMasterView1> ClaimMasterView1s { get; set; }
        public virtual DbSet<ClaimMasterViewForDamage> ClaimMasterViewForDamages { get; set; }
        public virtual DbSet<ClaimMasterViewForDamage1> ClaimMasterViewForDamage1s { get; set; }
        public virtual DbSet<ClaimMasterViewForDamageMaterial> ClaimMasterViewForDamageMaterials { get; set; }
        public virtual DbSet<ClaimMtagreedMargin> ClaimMtagreedMargins { get; set; }
        public virtual DbSet<ClaimMtagreedMarginDataView> ClaimMtagreedMarginDataViews { get; set; }
        public virtual DbSet<ClaimMtrate> ClaimMtrates { get; set; }
        public virtual DbSet<ClaimMtsecondarySale> ClaimMtsecondarySales { get; set; }
        public virtual DbSet<ClaimNsddetail> ClaimNsddetails { get; set; }
        public virtual DbSet<ClaimP> ClaimPs { get; set; }
        public virtual DbSet<ClaimPollydut> ClaimPollyduts { get; set; }
        public virtual DbSet<ClaimPollydutView> ClaimPollydutViews { get; set; }
        public virtual DbSet<ClaimPsview> ClaimPsviews { get; set; }
        public virtual DbSet<ClaimRmdatum> ClaimRmdata { get; set; }
        public virtual DbSet<ClaimSendAsm> ClaimSendAsms { get; set; }
        public virtual DbSet<ClaimSoa> ClaimSoas { get; set; }
        public virtual DbSet<ClaimStorageLocation> ClaimStorageLocations { get; set; }
        public virtual DbSet<ClaimTmdatum> ClaimTmdata { get; set; }
        public virtual DbSet<ClaimTypeTag> ClaimTypeTags { get; set; }
        public virtual DbSet<ClaimVatpdomrappoveInfo> ClaimVatpdomrappoveInfos { get; set; }
        public virtual DbSet<Clearance> Clearances { get; set; }
        public virtual DbSet<ClosingFinancialView> ClosingFinancialViews { get; set; }
        public virtual DbSet<ClosingIoListView> ClosingIoListViews { get; set; }
        public virtual DbSet<ClosingIoallocationRuleView> ClosingIoallocationRuleViews { get; set; }
        public virtual DbSet<ClosingIocbt> ClosingIocbts { get; set; }
        public virtual DbSet<ClosingIocbtdataView> ClosingIocbtdataViews { get; set; }
        public virtual DbSet<ClosingIodetail> ClosingIodetails { get; set; }
        public virtual DbSet<ClosingIomaster> ClosingIomasters { get; set; }
        public virtual DbSet<ClosingIomasterView> ClosingIomasterViews { get; set; }
        public virtual DbSet<ClosingIorule> ClosingIorules { get; set; }
        public virtual DbSet<ClosingProcessedDataView> ClosingProcessedDataViews { get; set; }
        public virtual DbSet<ClosingProcessedDatum> ClosingProcessedData { get; set; }
        public virtual DbSet<CmgradeCategoryView> CmgradeCategoryViews { get; set; }
        public virtual DbSet<CmsalaryStructureView> CmsalaryStructureViews { get; set; }
        public virtual DbSet<CompanyInfo> CompanyInfos { get; set; }
        public virtual DbSet<CustomerMaster> CustomerMasters { get; set; }
        public virtual DbSet<DailySecondarySalse> DailySecondarySalses { get; set; }
        public virtual DbSet<DamageSalesValue> DamageSalesValues { get; set; }
        public virtual DbSet<Ddclaim> Ddclaims { get; set; }
        public virtual DbSet<DdclaimDetail> DdclaimDetails { get; set; }
        public virtual DbSet<DdclaimDetailView> DdclaimDetailViews { get; set; }
        public virtual DbSet<DdclaimMaster> DdclaimMasters { get; set; }
        public virtual DbSet<DdclaimMasterView> DdclaimMasterViews { get; set; }
        public virtual DbSet<DdclaimSendAsm> DdclaimSendAsms { get; set; }
        public virtual DbSet<DdclaimSource> DdclaimSources { get; set; }
        public virtual DbSet<DepartmentView> DepartmentViews { get; set; }
        public virtual DbSet<DigradeGroupView> DigradeGroupViews { get; set; }
        public virtual DbSet<Eccproduct> Eccproducts { get; set; }
        public virtual DbSet<Eccproduct1> Eccproduct1s { get; set; }
        public virtual DbSet<EccproductTemp> EccproductTemps { get; set; }
        public virtual DbSet<EccproductTemp2> EccproductTemp2s { get; set; }
        public virtual DbSet<Expenditure> Expenditures { get; set; }
        public virtual DbSet<FileAttachment> FileAttachments { get; set; }
        public virtual DbSet<FileProcessLog> FileProcessLogs { get; set; }
        public virtual DbSet<FileTransferLogDmstoUpropose> FileTransferLogDmstoUproposes { get; set; }
        public virtual DbSet<FinancialImpactView> FinancialImpactViews { get; set; }
        public virtual DbSet<ForecastOpsbrand> ForecastOpsbrands { get; set; }
        public virtual DbSet<ForecastOpsdetail> ForecastOpsdetails { get; set; }
        public virtual DbSet<ForecastOpsmaster> ForecastOpsmasters { get; set; }
        public virtual DbSet<ForecastProcessedDataView> ForecastProcessedDataViews { get; set; }
        public virtual DbSet<ForecastProcessedDatum> ForecastProcessedData { get; set; }
        public virtual DbSet<HistoryAbauthoUser> HistoryAbauthoUsers { get; set; }
        public virtual DbSet<HistoryAbdetail> HistoryAbdetails { get; set; }
        public virtual DbSet<HistoryAbmaster> HistoryAbmasters { get; set; }
        public virtual DbSet<HistoryAbproduct> HistoryAbproducts { get; set; }
        public virtual DbSet<HistoryAbproductChannel> HistoryAbproductChannels { get; set; }
        public virtual DbSet<HistoryOpsbrand> HistoryOpsbrands { get; set; }
        public virtual DbSet<HistoryOpsdetail> HistoryOpsdetails { get; set; }
        public virtual DbSet<HolidaySetup> HolidaySetups { get; set; }
        public virtual DbSet<Jccalendar> Jccalendars { get; set; }
        public virtual DbSet<JccalendarView> JccalendarViews { get; set; }
        public virtual DbSet<KeyAccount> KeyAccounts { get; set; }
        public virtual DbSet<LateClaimUploadCategorySetUp> LateClaimUploadCategorySetUps { get; set; }
        public virtual DbSet<LateClaimUploadDistributorSetUp> LateClaimUploadDistributorSetUps { get; set; }
        public virtual DbSet<LateClaimUploadDistributorSetUpView> LateClaimUploadDistributorSetUpViews { get; set; }
        public virtual DbSet<LateClaimUploadSetUp> LateClaimUploadSetUps { get; set; }
        public virtual DbSet<ListOfOnMillionAbview> ListOfOnMillionAbviews { get; set; }
        public virtual DbSet<LocationEmployee> LocationEmployees { get; set; }
        public virtual DbSet<LocationEmployee2> LocationEmployee2s { get; set; }
        public virtual DbSet<LocationEmployeeNew> LocationEmployeeNews { get; set; }
        public virtual DbSet<LocationEmployeeVertically> LocationEmployeeVerticallies { get; set; }
        public virtual DbSet<LocationEmployeeView> LocationEmployeeViews { get; set; }
        public virtual DbSet<LocationUserVertically> LocationUserVerticallies { get; set; }
        public virtual DbSet<LocationVertically> LocationVerticallies { get; set; }
        public virtual DbSet<LocationVerticallyForUnibd> LocationVerticallyForUnibds { get; set; }
        public virtual DbSet<LocationVerticallyNotInUse> LocationVerticallyNotInUses { get; set; }
        public virtual DbSet<LockedScenario> LockedScenarios { get; set; }
        public virtual DbSet<ManualClaimPendingAmount> ManualClaimPendingAmounts { get; set; }
        public virtual DbSet<MatrixProcessDatum> MatricesProcessData { get; set; }
        public virtual DbSet<MatrixProduct> MatricesProduct { get; set; }
        public virtual DbSet<MatrixProduct2020> MatricesProduct2020 { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<MobileAttachment> MobileAttachments { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<ModuleGl> ModuleGls { get; set; }
        public virtual DbSet<MonthlyClaimManual> MonthlyClaimManuals { get; set; }
        public virtual DbSet<MonthlySalesTrendVolumeView> MonthlySalesTrendVolumeViews { get; set; }
        public virtual DbSet<Npsratio> Npsratios { get; set; }
        public virtual DbSet<Npsratio12> Npsratio12s { get; set; }
        public virtual DbSet<NpsratioBmilocal> NpsratioBmilocals { get; set; }
        public virtual DbSet<Opsbrand> Opsbrands { get; set; }
        public virtual DbSet<Opsdetail> Opsdetails { get; set; }
        public virtual DbSet<Opsmaster> Opsmasters { get; set; }
        public virtual DbSet<Pending> Pendings { get; set; }
        public virtual DbSet<PendingBill> PendingBills { get; set; }
        public virtual DbSet<PendingClaimAmount> PendingClaimAmounts { get; set; }
        public virtual DbSet<PendingClaimAmount1> PendingClaimAmount1s { get; set; }
        public virtual DbSet<PhupdateDumpDatum> PhupdateDumpData { get; set; }
        public virtual DbSet<PoavailibilityComplain> PoavailibilityComplains { get; set; }
        public virtual DbSet<Podmaster> Podmasters { get; set; }
        public virtual DbSet<PoemployeeGroup> PoemployeeGroups { get; set; }
        public virtual DbSet<PoemployeeRole> PoemployeeRoles { get; set; }
        public virtual DbSet<Pomarket> Pomarkets { get; set; }
        public virtual DbSet<PomustSku> PomustSkus { get; set; }
        public virtual DbSet<PoproductComplain> PoproductComplains { get; set; }
        public virtual DbSet<Ppdetail> Ppdetails { get; set; }
        public virtual DbSet<PpdetailAuthoUser> PpdetailAuthoUsers { get; set; }
        public virtual DbSet<PpdetailQuery> PpdetailQueries { get; set; }
        public virtual DbSet<PpdetailView> PpdetailViews { get; set; }
        public virtual DbSet<PpemailCirculation> PpemailCirculations { get; set; }
        public virtual DbSet<Ppmaster> Ppmasters { get; set; }
        public virtual DbSet<PpmasterAuthoUser> PpmasterAuthoUsers { get; set; }
        public virtual DbSet<PpmasterQuery> PpmasterQueries { get; set; }
        public virtual DbSet<PpmasterView> PpmasterViews { get; set; }
        public virtual DbSet<PpuserProduct> PpuserProducts { get; set; }
        public virtual DbSet<PpuserRole> PpuserRoles { get; set; }
        public virtual DbSet<PrimarySale> PrimarySales { get; set; }
        public virtual DbSet<PrimarySalesDaily> PrimarySalesDailies { get; set; }
        public virtual DbSet<PrimarySalesDetail> PrimarySalesDetails { get; set; }
        public virtual DbSet<PrimarySalesMaster> PrimarySalesMasters { get; set; }
        public virtual DbSet<ProductGroup> ProductGroups { get; set; }
        public virtual DbSet<ProductGroupAuthoUser> ProductGroupAuthoUsers { get; set; }
        public virtual DbSet<ProductGroupSubBrand> ProductGroupSubBrands { get; set; }
        public virtual DbSet<Rejection> Rejections { get; set; }
        public virtual DbSet<ReportDetail> ReportDetails { get; set; }
        public virtual DbSet<ReportDetailFormula> ReportDetailFormulas { get; set; }
        public virtual DbSet<ReportMaster> ReportMasters { get; set; }
        public virtual DbSet<ResearchType> ResearchTypes { get; set; }
        public virtual DbSet<Sapioallocation> Sapioallocations { get; set; }
        public virtual DbSet<Scenario> Scenarios { get; set; }
        public virtual DbSet<SecondarySale> SecondarySales { get; set; }
        public virtual DbSet<SendEmailQueue> SendEmailQueues { get; set; }
        public virtual DbSet<Smsmaster> Smsmasters { get; set; }
        public virtual DbSet<SoaTemp> SoaTemps { get; set; }
        public virtual DbSet<SoaTemp2> SoaTemp2s { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<TempSoa> TempSoas { get; set; }
        public virtual DbSet<TempWipamountDetail> TempWipamountDetails { get; set; }
        public virtual DbSet<ThisSystem> ThisSystems { get; set; }
        public virtual DbSet<TimelineView> TimelineViews { get; set; }
        public virtual DbSet<TmrsmforUnibd> TmrsmforUnibds { get; set; }
        public virtual DbSet<Ttsbscbtview> Ttsbscbtviews { get; set; }
        public virtual DbSet<TtspnLcbtview> TtspnLcbtviews { get; set; }
        public virtual DbSet<UnibdClaim> UnibdClaims { get; set; }
        public virtual DbSet<UpdatedProduct> UpdatedProducts { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<UserLimit> UserLimits { get; set; }
        public virtual DbSet<UserLimitModule> UserLimitModules { get; set; }
        public virtual DbSet<UserPermitionReportView> UserPermitionReportViews { get; set; }
        public virtual DbSet<ValueList> ValueLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=145.17.58.8;Database=AHS_IBP;User ID=sa;Password=Unilever123!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbactionLog>(entity =>
            {
                entity.ToTable("ABActionLog");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ActionUserId).HasColumnName("ActionUserID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Screen)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Abamend>(entity =>
            {
                entity.ToTable("ABAmend");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abtype).HasColumnName("ABType");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrAbamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CurrABAmount");

                entity.Property(e => e.CurrAbdetails)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("CurrABDetails")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrAbobjective)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("CurrABobjective")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrActEndDate).HasColumnType("datetime");

                entity.Property(e => e.CurrActStartDate).HasColumnType("datetime");

                entity.Property(e => e.CurrClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrNpiamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CurrNPIAmount");

                entity.Property(e => e.PrevAbamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PrevABAmount");

                entity.Property(e => e.PrevAbdetails)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("PrevABDetails")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PrevAbobjective)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("PrevABobjective")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PrevActEndDate).HasColumnType("datetime");

                entity.Property(e => e.PrevActStartDate).HasColumnType("datetime");

                entity.Property(e => e.PrevClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrevNpiamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PrevNPIAmount");

                entity.HasOne(d => d.Ab)
                    .WithMany(p => p.Abamends)
                    .HasForeignKey(d => d.Abid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABAmend_ABMaster");
            });

            modelBuilder.Entity<AbauthoUser>(entity =>
            {
                entity.ToTable("ABAuthoUser");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AmendNo).HasDefaultValueSql("(0)");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsRetrospective).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProcessTime).HasColumnType("datetime");

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.AbauthoUsers)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthoProcess_ABMaster");
            });

            modelBuilder.Entity<AbauthoUserAmend>(entity =>
            {
                entity.ToTable("ABAuthoUserAmend");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IsRetrospective).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProcessTime).HasColumnType("datetime");

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<AbauthorizerMail>(entity =>
            {
                entity.ToTable("ABAuthorizerMail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.MailSendDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.MailSendYear).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AbbudgetPercentage>(entity =>
            {
                entity.ToTable("ABBudgetPercentage");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.ActivityStartDate).HasColumnType("datetime");

                entity.Property(e => e.BudgetPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.15))");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2020-06-08')");

                entity.HasOne(d => d.Ab)
                    .WithMany(p => p.AbbudgetPercentages)
                    .HasForeignKey(d => d.Abid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ABBudgetPe__ABID__12AFF206");
            });

            modelBuilder.Entity<Abchannel>(entity =>
            {
                entity.ToTable("ABChannel");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChannelId).HasColumnName("ChannelID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<Abcost>(entity =>
            {
                entity.ToTable("ABCost");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpTypeId).HasColumnName("ExpTypeID");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.WorkType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.ExpType)
                    .WithMany(p => p.Abcosts)
                    .HasForeignKey(d => d.ExpTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABCost_Expenditure");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Abcosts)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ODABCost_ABMaster");
            });

            modelBuilder.Entity<AbdataView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ABDataView");

                entity.Property(e => e.Abamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ABAmount");

                entity.Property(e => e.Abamount1)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("ABAmount1");

                entity.Property(e => e.Abdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ABDate");

                entity.Property(e => e.Abdetails)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ABDetails");

                entity.Property(e => e.AbendDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ABEndDate");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.AbslNo).HasColumnName("ABSlNo");

                entity.Property(e => e.AbstartDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ABStartDate");

                entity.Property(e => e.Abtype).HasColumnName("ABType");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityEndDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityStartDate).HasColumnType("datetime");

                entity.Property(e => e.Agreed)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AmendValue).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.ApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.Approved)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Authorized)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.ClosureDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EndDateIntValue)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsFdconsult).HasColumnName("IsFDConsult");

                entity.Property(e => e.Npiamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NPIAmount");

                entity.Property(e => e.PaymentAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitCenter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProvisionAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Send)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StartDateIntValue)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<Abdatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ABData");

                entity.Property(e => e.Abamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ABAmount");

                entity.Property(e => e.Abamount1)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("ABAmount1");

                entity.Property(e => e.Abdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ABDate");

                entity.Property(e => e.Abdetails)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ABDetails");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.AbslNo).HasColumnName("ABSlNo");

                entity.Property(e => e.Abtype).HasColumnName("ABType");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityEndDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityStartDate).HasColumnType("datetime");

                entity.Property(e => e.Agreed)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AmendValue).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.ApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.Approved)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Authorized)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.ClosureDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsFdconsult).HasColumnName("IsFDConsult");

                entity.Property(e => e.Npiamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NPIAmount");

                entity.Property(e => e.PaymentAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitCenter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProvisionAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Send)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<AbdeleteAuthorization>(entity =>
            {
                entity.ToTable("ABDeleteAuthorization");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AuthoriseDate).HasColumnType("datetime");

                entity.Property(e => e.AuthoriseText)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthoriseUserId).HasColumnName("AuthoriseUserID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.RequestText)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RequestUserId).HasColumnName("RequestUserID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.AbdeleteAuthorizations)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABDeleteAuthorization_ABMaster");
            });

            modelBuilder.Entity<Abdetail>(entity =>
            {
                entity.ToTable("ABDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.AgencyTypeId).HasColumnName("AgencyTypeID");

                entity.Property(e => e.AiringDate).HasColumnType("datetime");

                entity.Property(e => e.Background)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CategoryCode)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EstimatedRoi)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EstimatedROI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExpTypeId).HasColumnName("ExpTypeID");

                entity.Property(e => e.FifthLvlResearchTypeId).HasColumnName("FifthLvlResearchTypeID");

                entity.Property(e => e.FirstLvlResearchTypeId).HasColumnName("FirstLvlResearchTypeID");

                entity.Property(e => e.FirstSendDate).HasColumnType("date");

                entity.Property(e => e.ForecastScenarioId).HasColumnName("ForecastScenarioID");

                entity.Property(e => e.ForthLvlResearchTypeId).HasColumnName("ForthLvlResearchTypeID");

                entity.Property(e => e.FrequencyComments)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FrequencyValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Grpcomments)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("GRPComments")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Grpvalue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GRPValue");

                entity.Property(e => e.InfoProbScope)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Investment)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsNegetiveRoi).HasColumnName("IsNegetiveROI");

                entity.Property(e => e.IsRmfund).HasColumnName("IsRMFund");

                entity.Property(e => e.JobDescription)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MeasureCriteria)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Methodology)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Objective)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Omquarter).HasColumnName("OMQuarter");

                entity.Property(e => e.OpsPlanId).HasColumnName("OpsPlanID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PostEvaluation)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PreviousActivityLearnings)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReachComments)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReachValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RecomUserId).HasColumnName("RecomUserID");

                entity.Property(e => e.RegionIds)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RegionIDs")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Roicalculation)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("ROICalculation")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rotcriteria)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("ROTCriteria")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rotrewards)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("ROTRewards")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SampleRevDate).HasColumnType("datetime");

                entity.Property(e => e.SecondLvlResearchTypeId).HasColumnName("SecondLvlResearchTypeID");

                entity.Property(e => e.SoaslabAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SOASlabAmount");

                entity.Property(e => e.StimulationRevDate).HasColumnType("datetime");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.TgtAudienceId).HasColumnName("TgtAudienceID");

                entity.Property(e => e.ThirdtLvlResearchTypeId).HasColumnName("ThirdtLvlResearchTypeID");

                entity.Property(e => e.TradeType).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ActivityType)
                    .WithMany(p => p.Abdetails)
                    .HasForeignKey(d => d.ActivityTypeId)
                    .HasConstraintName("FK_ABDetail_ValueList");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.AbdetailsNavigation)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABDetail_ABMaster");
            });

            modelBuilder.Entity<Abevcost>(entity =>
            {
                entity.ToTable("ABEVCost");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MediaUsed)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Skucode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SKUCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Abevcosts)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVABCost_ABMaster");
            });

            modelBuilder.Entity<AbkeyAccount>(entity =>
            {
                entity.ToTable("ABKeyAccount");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.KeyAccountId).HasColumnName("KeyAccountID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.KeyAccount)
                    .WithMany(p => p.AbkeyAccounts)
                    .HasForeignKey(d => d.KeyAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABKeyAccount_KeyAccount");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.AbkeyAccounts)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABKeyAccount_ABMaster");
            });

            modelBuilder.Entity<Abmaster>(entity =>
            {
                entity.ToTable("ABMaster");

                entity.HasIndex(e => e.Abnumber, "IX_ABMaster")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ABAmount");

                entity.Property(e => e.Abdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ABDate");

                entity.Property(e => e.Abdetails)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ABDetails")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AbslNo).HasColumnName("ABSlNo");

                entity.Property(e => e.Abtype).HasColumnName("ABType");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityEndDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityStartDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.ChargeAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.ClosureDate).HasColumnType("datetime");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.InvoiceDiscountType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1-off invoice,2- on invoice");

                entity.Property(e => e.IsBudgeted)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsFdconsult).HasColumnName("IsFDConsult");

                entity.Property(e => e.Npiamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NPIAmount");

                entity.Property(e => e.PaymentAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProfitCenter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProvisionAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SystemType).HasComment("0-None,1-Ariba,2-Non-Ariba");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<Abmaster1>(entity =>
            {
                entity.ToTable("ABMasters");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ABAmount");

                entity.Property(e => e.Abdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ABDate");

                entity.Property(e => e.Abdetails).HasColumnName("ABDetails");

                entity.Property(e => e.Abnumber).HasColumnName("ABNumber");

                entity.Property(e => e.AbslNo).HasColumnName("ABSlNo");

                entity.Property(e => e.Abtype).HasColumnName("ABType");

                entity.Property(e => e.ActivityEndDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityStartDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.ClosureDate).HasColumnType("datetime");

                entity.Property(e => e.IsFdconsult).HasColumnName("IsFDConsult");

                entity.Property(e => e.Npiamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NPIAmount");
            });

            modelBuilder.Entity<AbmasterView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ABMasterView");

                entity.Property(e => e.Abamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ABAmount");

                entity.Property(e => e.Abamount1)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("ABAmount1");

                entity.Property(e => e.AbamountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ABAmountMillionFormat");

                entity.Property(e => e.Abdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ABDate");

                entity.Property(e => e.AbdateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ABDateFormatted");

                entity.Property(e => e.Abdetails)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ABDetails");

                entity.Property(e => e.AbendDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ABEndDate");

                entity.Property(e => e.AbmonthYearText)
                    .HasMaxLength(35)
                    .HasColumnName("ABMonthYearText");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.Abnumbers)
                    .IsRequired()
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("ABNumbers");

                entity.Property(e => e.AbslNo).HasColumnName("ABSlNo");

                entity.Property(e => e.AbstartDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ABStartDate");

                entity.Property(e => e.Abtype).HasColumnName("ABType");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityEndDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityStartDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.AgencyTypeId).HasColumnName("AgencyTypeID");

                entity.Property(e => e.Agreed)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AiringDate).HasColumnType("datetime");

                entity.Property(e => e.AiringDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AmendAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.AmendValue).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.ApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovalDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Approved)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Authorized)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Background)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.BriefNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryCode)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.ClosureDate).HasColumnType("datetime");

                entity.Property(e => e.ClosureDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.Eh4name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EH4Name");

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EndDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.ErrorMessage)
                    .HasMaxLength(47)
                    .IsUnicode(false);

                entity.Property(e => e.EstimatedRoi)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EstimatedROI");

                entity.Property(e => e.ExpTypeId).HasColumnName("ExpTypeID");

                entity.Property(e => e.FifthDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FifthLvlResearchTypeId).HasColumnName("FifthLvlResearchTypeID");

                entity.Property(e => e.FirstDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLvlResearchTypeId).HasColumnName("FirstLvlResearchTypeID");

                entity.Property(e => e.ForthDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForthLvlResearchTypeId).HasColumnName("ForthLvlResearchTypeID");

                entity.Property(e => e.FullName)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Ibid).HasColumnName("IBID");

                entity.Property(e => e.Ibno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IBNo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InfoProbScope)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDiscount)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsFdconsult).HasColumnName("IsFDConsult");

                entity.Property(e => e.JobDescription)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Mbid).HasColumnName("MBID");

                entity.Property(e => e.MeasureCriteria)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Methodology)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Npiamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NPIAmount");

                entity.Property(e => e.NpiamountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NPIAmountMillionFormat");

                entity.Property(e => e.Objective)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Omquarter).HasColumnName("OMQuarter");

                entity.Property(e => e.OmquarterText)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("OMQuarterText");

                entity.Property(e => e.OpsPlanId).HasColumnName("OpsPlanID");

                entity.Property(e => e.PaymentAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PendingAbusers)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("PendingABUsers");

                entity.Property(e => e.ProfitCenter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProvisionAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecomUserId).HasColumnName("RecomUserID");

                entity.Property(e => e.RecommendUser)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.RefNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rotcriteria)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("ROTCriteria");

                entity.Property(e => e.Rotrewards)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("ROTRewards");

                entity.Property(e => e.SampleRevDate).HasColumnType("datetime");

                entity.Property(e => e.SecondDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondLvlResearchTypeId).HasColumnName("SecondLvlResearchTypeID");

                entity.Property(e => e.Send)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StartDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StatusText)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.StimulationRevDate).HasColumnType("datetime");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TargetAudience)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TgtAudienceId).HasColumnName("TgtAudienceID");

                entity.Property(e => e.ThirdtDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdtLvlResearchTypeId).HasColumnName("ThirdtLvlResearchTypeID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<AbmasterView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ABMasterView1");

                entity.Property(e => e.Abamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ABAmount");

                entity.Property(e => e.Abamount1)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("ABAmount1");

                entity.Property(e => e.AbamountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ABAmountMillionFormat");

                entity.Property(e => e.Abdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ABDate");

                entity.Property(e => e.AbdateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ABDateFormatted");

                entity.Property(e => e.Abdetails)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ABDetails");

                entity.Property(e => e.AbendDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ABEndDate");

                entity.Property(e => e.AbmonthYearText)
                    .HasMaxLength(35)
                    .HasColumnName("ABMonthYearText");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.Abnumbers)
                    .IsRequired()
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("ABNumbers");

                entity.Property(e => e.AbslNo).HasColumnName("ABSlNo");

                entity.Property(e => e.AbstartDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ABStartDate");

                entity.Property(e => e.Abtype).HasColumnName("ABType");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityEndDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityStartDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.AgencyTypeId).HasColumnName("AgencyTypeID");

                entity.Property(e => e.Agreed)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AiringDate).HasColumnType("datetime");

                entity.Property(e => e.AiringDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AmendAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.AmendValue).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.ApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovalDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Approved)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Authorized)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Background)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.BriefNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryCode)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.ClosureDate).HasColumnType("datetime");

                entity.Property(e => e.ClosureDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.Eh4name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EH4Name");

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EndDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.ErrorMessage)
                    .HasMaxLength(47)
                    .IsUnicode(false);

                entity.Property(e => e.EstimatedRoi)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EstimatedROI");

                entity.Property(e => e.ExpTypeId).HasColumnName("ExpTypeID");

                entity.Property(e => e.FifthDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FifthLvlResearchTypeId).HasColumnName("FifthLvlResearchTypeID");

                entity.Property(e => e.FirstDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLvlResearchTypeId).HasColumnName("FirstLvlResearchTypeID");

                entity.Property(e => e.ForthDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForthLvlResearchTypeId).HasColumnName("ForthLvlResearchTypeID");

                entity.Property(e => e.FullName)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Ibid).HasColumnName("IBID");

                entity.Property(e => e.Ibno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IBNo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InfoProbScope)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDiscount)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsFdconsult).HasColumnName("IsFDConsult");

                entity.Property(e => e.JobDescription)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Mbid).HasColumnName("MBID");

                entity.Property(e => e.MeasureCriteria)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Methodology)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Npiamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NPIAmount");

                entity.Property(e => e.NpiamountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NPIAmountMillionFormat");

                entity.Property(e => e.Objective)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Omquarter).HasColumnName("OMQuarter");

                entity.Property(e => e.OmquarterText)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("OMQuarterText");

                entity.Property(e => e.OpsPlanId).HasColumnName("OpsPlanID");

                entity.Property(e => e.PaymentAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PendingAbusers)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("PendingABUsers");

                entity.Property(e => e.ProfitCenter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProvisionAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecomUserId).HasColumnName("RecomUserID");

                entity.Property(e => e.RecommendUser)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.RefNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rotcriteria)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("ROTCriteria");

                entity.Property(e => e.Rotrewards)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("ROTRewards");

                entity.Property(e => e.SampleRevDate).HasColumnType("datetime");

                entity.Property(e => e.SecondDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondLvlResearchTypeId).HasColumnName("SecondLvlResearchTypeID");

                entity.Property(e => e.Send)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StartDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StatusText)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.StimulationRevDate).HasColumnType("datetime");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TargetAudience)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TgtAudienceId).HasColumnName("TgtAudienceID");

                entity.Property(e => e.ThirdtDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdtLvlResearchTypeId).HasColumnName("ThirdtLvlResearchTypeID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<Abmrsupplier>(entity =>
            {
                entity.ToTable("ABMRSupplier");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActionStandard)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AgencySelection)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Abmrsuppliers)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MRSupplier_ABMaster");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Abmrsuppliers)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MRSupplier_Supplier");
            });

            modelBuilder.Entity<AbpendingView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ABPendingView");

                entity.Property(e => e.Abamount)
                    .HasColumnType("money")
                    .HasColumnName("ABAmount");

                entity.Property(e => e.AbamountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ABAmountMillionFormat");

                entity.Property(e => e.Abdescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ABDescription");

                entity.Property(e => e.Abdetails)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ABDetails");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.Abtype).HasColumnName("ABType");

                entity.Property(e => e.ActivityStartDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverName)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoginId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LoginID");

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PendingStatus)
                    .IsRequired()
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Abprice>(entity =>
            {
                entity.ToTable("ABPrice");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActualGm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ActualGM");

                entity.Property(e => e.ActualRsp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ActualRSP");

                entity.Property(e => e.ActualTm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ActualTM");

                entity.Property(e => e.AprilGp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AprilGP");

                entity.Property(e => e.AprilTurnover).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AprilVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AugustGp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AugustGP");

                entity.Property(e => e.AugustTurnover).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AugustVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompetitorRsp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CompetitorRSP");

                entity.Property(e => e.CompetitorTm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CompetitorTM");

                entity.Property(e => e.DecemberGp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DecemberGP");

                entity.Property(e => e.DecemberTurnover).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DecemberVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DmoptionFour)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DMOptionFour");

                entity.Property(e => e.DmoptionOne)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DMOptionOne");

                entity.Property(e => e.DmoptionThree)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DMOptionThree");

                entity.Property(e => e.DmoptionTwo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DMOptionTwo");

                entity.Property(e => e.DozonOptionFour).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DozonOptionOne).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DozonOptionThree).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DozonOptionTwo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DvoptionFour)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DVOptionFour");

                entity.Property(e => e.DvoptionOne)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DVOptionOne");

                entity.Property(e => e.DvoptionThree)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DVOptionThree");

                entity.Property(e => e.DvoptionTwo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DVOptionTwo");

                entity.Property(e => e.DvpoptionFour)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DVPOptionFour");

                entity.Property(e => e.DvpoptionOne)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DVPOptionOne");

                entity.Property(e => e.DvpoptionThree)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DVPOptionThree");

                entity.Property(e => e.DvpoptionTwo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DVPOptionTwo");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.FbcoptionFour)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FBCOptionFour");

                entity.Property(e => e.FbcoptionOne)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FBCOptionOne");

                entity.Property(e => e.FbcoptionThree)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FBCOptionThree");

                entity.Property(e => e.FbcoptionTwo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FBCOptionTwo");

                entity.Property(e => e.FebruaryGp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FebruaryGP");

                entity.Property(e => e.FebruaryTurnover).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FebruaryVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ForecastGm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ForecastGM");

                entity.Property(e => e.ForecastRsp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ForecastRSP");

                entity.Property(e => e.ForecastTm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ForecastTM");

                entity.Property(e => e.JanuaryGp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("JanuaryGP");

                entity.Property(e => e.JanuaryTurnover).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JanuaryVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JulyGp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("JulyGP");

                entity.Property(e => e.JulyTurnover).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JulyVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JuneGp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("JuneGP");

                entity.Property(e => e.JuneTurnover).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JuneVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastPriceChangeDate).HasColumnType("datetime");

                entity.Property(e => e.MarchGp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MarchGP");

                entity.Property(e => e.MarchTurnover).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MarchVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MayGp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MayGP");

                entity.Property(e => e.MayTurnover).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MayVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NovemberGp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NovemberGP");

                entity.Property(e => e.NovemberTurnover).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NovemberVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OctoberGp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OctoberGP");

                entity.Property(e => e.OctoberTurnover).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OctoberVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Ph9code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SeptemberGp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SeptemberGP");

                entity.Property(e => e.SeptemberTurnover).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SeptemberVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TmoptionFour)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TMOptionFour");

                entity.Property(e => e.TmoptionOne)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TMOptionOne");

                entity.Property(e => e.TmoptionThree)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TMOptionThree");

                entity.Property(e => e.TmoptionTwo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TMOptionTwo");

                entity.Property(e => e.UnitOptionFour).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitOptionOne).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitOptionThree).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitOptionTwo).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Abprices)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABPrice_ABMaster");
            });

            modelBuilder.Entity<AbpriceProposalView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ABPriceProposalView");

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityStartDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Background)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MarketShare)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.PriceChangeRisks)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Rationale)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Skus)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("SKUs");
            });

            modelBuilder.Entity<Abproduct>(entity =>
            {
                entity.ToTable("ABProduct");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abratio)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ABRatio");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpTypeId).HasColumnName("ExpTypeID");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MasterItem)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Npsratio)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NPSRatio");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Ph10code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph8code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph9code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PromoActualValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromoInputValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Roicalculation)
                    .IsRequired()
                    .HasColumnName("ROICalculation")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TargetVolume).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Abproducts)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABProduct_ABMaster");
            });

            modelBuilder.Entity<Abproduct1>(entity =>
            {
                entity.ToTable("ABProduct1");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abratio)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ABRatio");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpTypeId).HasColumnName("ExpTypeID");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MasterItem)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Npsratio)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NPSRatio");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Ph10code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph8code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph9code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PromoActualValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromoInputValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Roicalculation)
                    .IsRequired()
                    .HasColumnName("ROICalculation")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TargetVolume).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<AbproductChannel>(entity =>
            {
                entity.ToTable("ABProductChannel");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.ChannelId).HasColumnName("ChannelID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.AbproductChannels)
                    .HasForeignKey(d => d.ChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABProductChannel_Channel");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.AbproductChannels)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABProductChannel_ABProduct");
            });

            modelBuilder.Entity<AbproductTarget>(entity =>
            {
                entity.ToTable("ABProductTarget");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.ActualVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Jcid).HasColumnName("JCID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.TargetVolume).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Abquery>(entity =>
            {
                entity.ToTable("ABQuery");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.QueryDate).HasColumnType("datetime");

                entity.Property(e => e.QueryText)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QueryUserId).HasColumnName("QueryUserID");

                entity.Property(e => e.ReplyDate).HasColumnType("datetime");

                entity.Property(e => e.ReplyText)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReplyUserId).HasColumnName("ReplyUserID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Abqueries)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABQuery_ABAuthoUser");
            });

            modelBuilder.Entity<AbqueryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ABQueryView");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.QueryDate).HasColumnType("datetime");

                entity.Property(e => e.QueryDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.QueryId).HasColumnName("QueryID");

                entity.Property(e => e.QueryText)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.QueryUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QueryUserDetail)
                    .IsRequired()
                    .HasMaxLength(154)
                    .IsUnicode(false);

                entity.Property(e => e.QueryUserId).HasColumnName("QueryUserID");

                entity.Property(e => e.Replied)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyDate).HasColumnType("datetime");

                entity.Property(e => e.ReplyDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyId).HasColumnName("ReplyID");

                entity.Property(e => e.ReplyText)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyUserDetail)
                    .HasMaxLength(154)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyUserId).HasColumnName("ReplyUserID");
            });

            modelBuilder.Entity<Abrejection>(entity =>
            {
                entity.ToTable("ABRejection");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExecutionDate).HasColumnType("datetime");

                entity.Property(e => e.Idvalue).HasColumnName("IDValue");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Abroi>(entity =>
            {
                entity.ToTable("ABROI");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActualScenarioId)
                    .HasColumnName("ActualScenarioID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ForecastScenarioId).HasColumnName("ForecastScenarioID");

                entity.Property(e => e.IncrementalGpachievement)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IncrementalGPAchievement");

                entity.Property(e => e.IncrementalVolumeAchievement).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NegativeRoijustification)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("NegativeROIJustification")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OtherPostCostJustification)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OtherPreCostJustification)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PlanAchievement).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PostBaseVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PostIncrementalGp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PostIncrementalGP");

                entity.Property(e => e.PostIncrementalVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PostNegativeRoijustification)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PostNegativeROIJustification")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostOtherPromoCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PostPlanVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PostPromoCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PostRoi)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PostROI");

                entity.Property(e => e.PostTotalInvestment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PreBaseVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PreIncrementalGp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PreIncrementalGP");

                entity.Property(e => e.PreIncrementalVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PreOtherPromoCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrePlanVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrePromoCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PreRoi)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PreROI");

                entity.Property(e => e.PreTotalInvestment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromoCostAchievement).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Roiachievement)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ROIAchievement");

                entity.Property(e => e.TotalInvestmentAchievement).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Abrois)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABROI_ABMaster");
            });

            modelBuilder.Entity<Abroidatum>(entity =>
            {
                entity.ToTable("ABROIData");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.AllocationRule).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseApril).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseAugust).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseDecember).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseFebruary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseJanuary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseJuly).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseJune).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseMarch).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseMay).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseNovember).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseOctober).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseSeptember).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EvaluationTypeId).HasColumnName("EvaluationTypeID");

                entity.Property(e => e.Gpapril)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GPApril");

                entity.Property(e => e.Gpaugust)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GPAugust");

                entity.Property(e => e.Gpdecember)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GPDecember");

                entity.Property(e => e.Gpfebruary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GPFebruary");

                entity.Property(e => e.Gpjanuary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GPJanuary");

                entity.Property(e => e.Gpjuly)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GPJuly");

                entity.Property(e => e.Gpjune)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GPJune");

                entity.Property(e => e.Gpmarch)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GPMarch");

                entity.Property(e => e.Gpmay)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GPMay");

                entity.Property(e => e.Gpmt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GPMT");

                entity.Property(e => e.Gpnovember)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GPNovember");

                entity.Property(e => e.Gpoctober)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GPOctober");

                entity.Property(e => e.Gpseptember)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GPSeptember");

                entity.Property(e => e.Gptotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GPTotal");

                entity.Property(e => e.Gsvapril)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSVApril");

                entity.Property(e => e.Gsvaugust)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSVAugust");

                entity.Property(e => e.Gsvdecember)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSVDecember");

                entity.Property(e => e.Gsvfebruary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSVFebruary");

                entity.Property(e => e.Gsvjanuary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSVJanuary");

                entity.Property(e => e.Gsvjuly)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSVJuly");

                entity.Property(e => e.Gsvjune)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSVJune");

                entity.Property(e => e.Gsvmarch)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSVMarch");

                entity.Property(e => e.Gsvmay)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSVMay");

                entity.Property(e => e.Gsvnovember)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSVNovember");

                entity.Property(e => e.Gsvoctober)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSVOctober");

                entity.Property(e => e.Gsvseptember)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSVSeptember");

                entity.Property(e => e.Gsvtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSVTotal");

                entity.Property(e => e.IncrementalGpapril)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IncrementalGPApril");

                entity.Property(e => e.IncrementalGpaugust)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IncrementalGPAugust");

                entity.Property(e => e.IncrementalGpdecember)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IncrementalGPDecember");

                entity.Property(e => e.IncrementalGpfebruary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IncrementalGPFebruary");

                entity.Property(e => e.IncrementalGpjanuary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IncrementalGPJanuary");

                entity.Property(e => e.IncrementalGpjuly)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IncrementalGPJuly");

                entity.Property(e => e.IncrementalGpjune)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IncrementalGPJune");

                entity.Property(e => e.IncrementalGpmarch)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IncrementalGPMarch");

                entity.Property(e => e.IncrementalGpmay)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IncrementalGPMay");

                entity.Property(e => e.IncrementalGpnovember)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IncrementalGPNovember");

                entity.Property(e => e.IncrementalGpoctober)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IncrementalGPOctober");

                entity.Property(e => e.IncrementalGpseptember)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IncrementalGPSeptember");

                entity.Property(e => e.IncrementalGptotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IncrementalGPTotal");

                entity.Property(e => e.InvestmentApril).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvestmentAugust).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvestmentDecember).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvestmentFebruary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvestmentJanuary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvestmentJuly).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvestmentJune).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvestmentMarch).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvestmentMay).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvestmentNovember).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvestmentOctober).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvestmentSeptember).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvestmentTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsRoi)
                    .IsRequired()
                    .HasColumnName("IsROI")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Justification)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Ph9code)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code");

                entity.Property(e => e.Ph9name)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("PH9Name");

                entity.Property(e => e.Roiapril)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ROIApril");

                entity.Property(e => e.Roiaugust)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ROIAugust");

                entity.Property(e => e.Roidecember)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ROIDecember");

                entity.Property(e => e.Roifebruary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ROIFebruary");

                entity.Property(e => e.Roijanuary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ROIJanuary");

                entity.Property(e => e.Roijuly)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ROIJuly");

                entity.Property(e => e.Roijune)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ROIJune");

                entity.Property(e => e.Roimarch)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ROIMarch");

                entity.Property(e => e.Roimay)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ROIMay");

                entity.Property(e => e.Roinovember)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ROINovember");

                entity.Property(e => e.Roioctober)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ROIOctober");

                entity.Property(e => e.Roiseptember)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ROISeptember");

                entity.Property(e => e.Roitotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ROITotal");

                entity.Property(e => e.Ttsapril)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TTSApril");

                entity.Property(e => e.Ttsaugust)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TTSAugust");

                entity.Property(e => e.Ttsdecember)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TTSDecember");

                entity.Property(e => e.Ttsfebruary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TTSFebruary");

                entity.Property(e => e.Ttsjanuary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TTSJanuary");

                entity.Property(e => e.Ttsjuly)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TTSJuly");

                entity.Property(e => e.Ttsjune)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TTSJune");

                entity.Property(e => e.Ttsmarch)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TTSMarch");

                entity.Property(e => e.Ttsmay)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TTSMay");

                entity.Property(e => e.Ttsnovember)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TTSNovember");

                entity.Property(e => e.Ttsoctober)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TTSOctober");

                entity.Property(e => e.Ttsseptember)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TTSSeptember");

                entity.Property(e => e.Ttstotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TTSTotal");

                entity.Property(e => e.VolumeApril).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VolumeAugust).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VolumeDecember).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VolumeFebruary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VolumeJanuary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VolumeJuly).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VolumeJune).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VolumeMarch).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VolumeMay).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VolumeNovember).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VolumeOctober).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VolumeSeptember).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VolumeTotal).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Absapio>(entity =>
            {
                entity.ToTable("ABSAPIO");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AbtypeId).HasColumnName("ABTypeID");

                entity.Property(e => e.ChannelId).HasColumnName("ChannelID");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.Ionumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IONumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<Absapiochannel>(entity =>
            {
                entity.ToTable("ABSAPIOChannel");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChannelId).HasColumnName("ChannelID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<AbslabUser>(entity =>
            {
                entity.ToTable("ABSlabUser");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ApproverTypeId).HasColumnName("ApproverTypeID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SoamasterId).HasColumnName("SOAMasterID");

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ApproverType)
                    .WithMany(p => p.AbslabUsers)
                    .HasForeignKey(d => d.ApproverTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABSlabUser_ValueList");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.AbslabUsers)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABSlabUser_ABSOASlab");

                entity.HasOne(d => d.Soamaster)
                    .WithMany(p => p.AbslabUsers)
                    .HasForeignKey(d => d.SoamasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABSlabUser_ABSOAMaster");
            });

            modelBuilder.Entity<AbslabUserHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ABSlabUserHistory");

                entity.Property(e => e.ApproverTypeId).HasColumnName("ApproverTypeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SoamasterId).HasColumnName("SOAMasterID");

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Absoamaster>(entity =>
            {
                entity.ToTable("ABSOAMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsNegativeRoi).HasColumnName("IsNegativeROI");

                entity.Property(e => e.IsRmfund).HasColumnName("IsRMFund");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.PhlevelId)
                    .HasColumnName("PHLevelID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.HasOne(d => d.ActivityType)
                    .WithMany(p => p.Absoamasters)
                    .HasForeignKey(d => d.ActivityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SOAMaster_ModuleGL");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Absoamasters)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SOAMaster_Module");

                entity.HasOne(d => d.Phlevel)
                    .WithMany(p => p.Absoamasters)
                    .HasForeignKey(d => d.PhlevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABSOAMaster_ValueList");
            });

            modelBuilder.Entity<AbsoamasterHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ABSOAMasterHistory");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsNegativeRoi).HasColumnName("IsNegativeROI");

                entity.Property(e => e.IsRmfund).HasColumnName("IsRMFund");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.PhlevelId).HasColumnName("PHLevelID");

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<AbsoanegativeRoi>(entity =>
            {
                entity.ToTable("ABSOANegativeROI");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ApproverTypeId).HasColumnName("ApproverTypeID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ApproverType)
                    .WithMany(p => p.AbsoanegativeRois)
                    .HasForeignKey(d => d.ApproverTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABSOANegativeROI_ValueList");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.AbsoanegativeRois)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABSOANegativeROI_ABSOAMaster");
            });

            modelBuilder.Entity<AbsoanegativeRoihistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ABSOANegativeROIHistory");

                entity.Property(e => e.ApproverTypeId).HasColumnName("ApproverTypeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Absoaproduct>(entity =>
            {
                entity.ToTable("ABSOAProduct");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Skucode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SKUCode");

                entity.Property(e => e.Skuname)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SKUName");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Absoaproducts)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABSOAProduct_ABSOAMaster");
            });

            modelBuilder.Entity<AbsoaproductHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ABSOAProductHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Skucode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SKUCode");

                entity.Property(e => e.Skuname)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SKUName");
            });

            modelBuilder.Entity<AbsoaretrospectiveUser>(entity =>
            {
                entity.ToTable("ABSOARetrospectiveUsers");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ApproverTypeId).HasColumnName("ApproverTypeID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.AbsoaretrospectiveUsers)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABSOARetrospectiveUsers_ABSOAMaster");
            });

            modelBuilder.Entity<AbsoaretrospectiveUsersHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ABSOARetrospectiveUsersHistory");

                entity.Property(e => e.ApproverTypeId).HasColumnName("ApproverTypeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AbsoarmfundUser>(entity =>
            {
                entity.ToTable("ABSOARMFundUser");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ApproverTypeId).HasColumnName("ApproverTypeID");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.AbsoarmfundUsers)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABSOARMFundUser_ABSOAMaster");
            });

            modelBuilder.Entity<AbsoarmfundUserHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ABSOARMFundUserHistory");

                entity.Property(e => e.ApproverTypeId).HasColumnName("ApproverTypeID");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Absoaslab>(entity =>
            {
                entity.ToTable("ABSOASlab");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaxValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Absoaslabs)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABSOASlab_ABSOAMaster");
            });

            modelBuilder.Entity<AbsoaslabHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ABSOASlabHistory");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaxValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<AbtagView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ABTagView");

                entity.Property(e => e.AbmoduleId).HasColumnName("ABModuleID");

                entity.Property(e => e.Acode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACode");

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.ValueTypeDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Abtvc>(entity =>
            {
                entity.ToTable("ABTVC");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Ph8code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tvcid).HasColumnName("TVCID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Abtvcs)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABTVC_ABMaster");
            });

            modelBuilder.Entity<ActionQue>(entity =>
            {
                entity.ToTable("ActionQue");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActionUserId).HasColumnName("ActionUserID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActivityTypeMeasureMappingView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ActivityTypeMeasureMappingView");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.MeasureCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MeasureDescription)
                    .HasMaxLength(37)
                    .IsUnicode(false);

                entity.Property(e => e.MeasureId).HasColumnName("MeasureID");

                entity.Property(e => e.ValueTypeDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AhsAllClaimDetail>(entity =>
            {
                entity.ToTable("AHS_AllClaimDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Damage-Amount,PerfectStore-ClaimAmount");

                entity.Property(e => e.ClaimNoDetail)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ClaimNo_Detail")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DamageCost)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Empty1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GiftAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Damage-Place,PerfectStore-Enrolled Outlet");

                entity.Property(e => e.PriceType)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('TP')")
                    .HasComment("Damage-PriceType,PerfectStore-Slab");

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Damage-ReasonCode,PerfectStore-Productcategory");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SKU")
                    .HasComment("Damage-SKU,PerfectStore-ProgramName");

                entity.Property(e => e.Skucase)
                    .HasColumnName("SKUCase")
                    .HasComment("Damage-SKUCase,PerfectStore-NoOfWinner");

                entity.Property(e => e.Skucode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SKUCode")
                    .HasComment("Damage-SKUCode,PerfectStore-ChannelName");

                entity.Property(e => e.Skuunit).HasColumnName("SKUUnit");

                entity.Property(e => e.TubeQty)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Damage-TubeQty,PerfectStore-GiftDescription");
            });

            modelBuilder.Entity<AhsAllClaimMaster>(entity =>
            {
                entity.ToTable("AHS_AllClaimMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CddapproveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CDDApproveDate");

                entity.Property(e => e.CdduserId).HasColumnName("CDDUserID");

                entity.Property(e => e.CdmapproveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CDMApproveDate");

                entity.Property(e => e.CdmuserId).HasColumnName("CDMUserID");

                entity.Property(e => e.ClaimDate)
                    .HasColumnType("datetime")
                    .HasComment("For Perfect Store Damage");

                entity.Property(e => e.ClaimNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.DepotCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.IsCddapprove).HasColumnName("IsCDDApprove");

                entity.Property(e => e.IsCdmapprove).HasColumnName("IsCDMApprove");

                entity.Property(e => e.IsTmmapprove).HasColumnName("IsTMMApprove");

                entity.Property(e => e.PercentageOfSecondarySales).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TmmapproveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TMMApproveDate");

                entity.Property(e => e.TmmuserId).HasColumnName("TMMUserID");

                entity.Property(e => e.ToDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AhsClaimType>(entity =>
            {
                entity.ToTable("AHS_ClaimType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AhsMailSendToDistributor>(entity =>
            {
                entity.ToTable("AHS_MailSendToDistributor");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DamageEmail)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PerfectStoreEmail)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<AhsSapAccrual>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AHS_SAP_Accrual");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrencyKey)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocumentDate)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocumentHeader)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocumentType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gui)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("GUI");

                entity.Property(e => e.ItemText)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Period)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostingDate)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostingKey)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProfitCenter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<AhsSapControlTable>(entity =>
            {
                entity.HasKey(e => e.Gui)
                    .HasName("PK_AHS_SAPControlTable");

                entity.ToTable("AHS_SAP_ControlTable");

                entity.Property(e => e.Gui)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("GUI");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY")
                    .IsFixedLength();

                entity.Property(e => e.Createdtime)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDTIME")
                    .IsFixedLength();

                entity.Property(e => e.Interfaceid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("INTERFACEID")
                    .IsFixedLength();

                entity.Property(e => e.Interfacename)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("INTERFACENAME")
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength();
            });

            modelBuilder.Entity<AhsSapCreditNote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AHS_SAP_CreditNote");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionType)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CreditNoteDate)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DistributionChannel)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Gui)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("GUI");

                entity.Property(e => e.Ionumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("IONumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PromotionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SalesDocumentType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOrganization)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToParty)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SoldToParty)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AhsSapCreditNoteAdjustmentDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AHS_SAP_CreditNote_Adjustment_Detail");

                entity.Property(e => e.CreditNoteLineId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CreditNoteLineID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreditNoteLineValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CreditNoteLineVolume).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CreditNoteType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gui)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("GUI");

                entity.Property(e => e.SalesOrganization)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("SKU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UOM")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<AhsSapCreditNoteAdjustmentMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AHS_SAP_CreditNote_Adjustment_Master");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreditNoteDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreditNoteId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CreditNoteID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreditNoteReason)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreditNoteType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreditNoteValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DistributorID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gui)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("GUI");

                entity.Property(e => e.OutletId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OutletID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pjpid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PJPID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalesOrganization)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalesTeamId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SalesTeamID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalesmanId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SalesmanID")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<AhsSapIomaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AHS_SAP_IOMaster");

                entity.Property(e => e.AccountAssingmentCategory)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Banner)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BrandPh)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("BrandPH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Brands)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BusinessUnit)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChannelCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ConsumpOccassClass01)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ConsumpOccassClass02)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ConsumpOccassClass03)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ControllingArea)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CpgcorporateProductGroup)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CPGCorporateProductGroup")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Division)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExternalOrderNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FunctionId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FunctionID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FunctionalArea)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GlobalCustomerCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gui)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("GUI");

                entity.Property(e => e.Iccid)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ICCID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Inouthome)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("INOUTHome")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ionumber)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("IONumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Iotype)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("IOType")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeyCustomerClass01)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeyCustomerClass02)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeyCustomerClass03)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocalLevel01)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocalSalesForce)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocalSalesRegion2)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Market)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaterialGroup11)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OperatHiera2)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OperatHiera4)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderNumber)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PackSize)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PersonResponsible)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessingGroup)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductCategory)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProfAnalysisAtCus)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProfitCenter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProfitabilityUnit)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalesDistrict)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalesOrg)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B001')");

                entity.Property(e => e.SalesOrganization)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SecondaryCustomer)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SettlementPercentageRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Statistical)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubBrand)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubBrandPh)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SubBrandPH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubDivision2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TradeFormatClass02)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TradeFormatClass03)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WorkEnd)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WorkStart)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<AhsSapIoplan>(entity =>
            {
                entity.HasKey(e => e.Gui)
                    .HasName("PK_AHS_IOPlan");

                entity.ToTable("AHS_SAP_IOPlan");

                entity.Property(e => e.Gui)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("GUI");

                entity.Property(e => e.CostElement)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiscalYear)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Ionumber)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("IONumber");

                entity.Property(e => e.Month1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Month10).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Month11).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Month12).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Month2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Month3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Month4).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Month5).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Month6).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Month7).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Month8).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Month9).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<AhsSapWeeklySecondarySale>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AHS_SAP_WeeklySecondarySales");

                entity.Property(e => e.ChannelName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GrossSalesValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Gui)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("GUI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nsv)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("NSV");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('''')");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalesOrganization)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B001')");

                entity.Property(e => e.SalesQuantity).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOM")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<AhsUser>(entity =>
            {
                entity.ToTable("AHS_User");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<AhsUserNew>(entity =>
            {
                entity.ToTable("AHS_User_New");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<AhsWf>(entity =>
            {
                entity.ToTable("AHS_WF");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FromEmployeeId)
                    .HasColumnName("FromEmployeeID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FromEmployeeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InitiatorId)
                    .HasColumnName("InitiatorID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InitiatorName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RequisitionId).HasColumnName("RequisitionID");

                entity.Property(e => e.RequisitionNo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubmitDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ToEmployeeId)
                    .HasColumnName("ToEmployeeID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ToEmployeeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WfsetupDetailId).HasColumnName("WFSetupDetailID");

                entity.Property(e => e.WfsetupMasterId).HasColumnName("WFSetupMasterID");
            });

            modelBuilder.Entity<Aitcbt>(entity =>
            {
                entity.ToTable("AITCBT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Cbt)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CBT");

                entity.Property(e => e.ClaimCategoryId).HasColumnName("ClaimCategoryID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<ArchiveClaimClp>(entity =>
            {
                entity.ToTable("ArchiveClaimCLP");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid)
                    .HasColumnName("ABID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GiftRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNewSystem)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Payout)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Slab)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<ArchiveClaimCoupon>(entity =>
            {
                entity.ToTable("ArchiveClaimCoupon");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid)
                    .HasColumnName("ABID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GiftRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNewSystem)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Payout)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Slab)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<ArchiveClaimDamage>(entity =>
            {
                entity.ToTable("ArchiveClaimDamage");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClaimAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("IF Place = C or D, then ClaimPrice * (SKUCase * PackSize) + SKUUnit else TradePrice * (SKUCase * PackSize) + SKUUnit");

                entity.Property(e => e.ClaimPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DamageReason)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DefectCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DefectDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InitialQuantity).HasComment("(SKUCase * PackSize) + SKUUnit");

                entity.Property(e => e.IsNsd).HasColumnName("IsNSD");

                entity.Property(e => e.ListPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Skucase).HasColumnName("SKUCase");

                entity.Property(e => e.Skucode)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("SKUCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Skuname)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SKUName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Skuunit).HasColumnName("SKUUnit");

                entity.Property(e => e.TradePrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ArchiveClaimDd>(entity =>
            {
                entity.ToTable("ArchiveClaimDD");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FreeSkucase).HasColumnName("FreeSKUCase");

                entity.Property(e => e.FreeSkucode)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("FreeSKUCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FreeSkuname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FreeSKUName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FreeSkuunit).HasColumnName("FreeSKUUnit");

                entity.Property(e => e.MasterSkuname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MasterSKUName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PromotionCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Skucase).HasColumnName("SKUCase");

                entity.Property(e => e.Skucode)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("SKUCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Skuunit).HasColumnName("SKUUnit");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<ArchiveClaimDff>(entity =>
            {
                entity.ToTable("ArchiveClaimDFF");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Achievement).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorGrade)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InitialClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsNewSystem)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Kpiname)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("KPIName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProgramCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Target).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ArchiveClaimDosti>(entity =>
            {
                entity.ToTable("ArchiveClaimDosti");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid)
                    .HasColumnName("ABID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNewSystem)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Payout)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Slab)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<ArchiveClaimManual>(entity =>
            {
                entity.ToTable("ArchiveClaimManual");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Aitamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AITAmount");

                entity.Property(e => e.Aitid).HasColumnName("AITID");

                entity.Property(e => e.BatchDate).HasColumnType("datetime");

                entity.Property(e => e.BatchNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Comments)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IsPartialSettelement).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SetteledAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SetteledDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ArchiveClaimMaster>(entity =>
            {
                entity.ToTable("ArchiveClaimMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid)
                    .HasColumnName("ABID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AbtypeId)
                    .HasColumnName("ABTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ait)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AIT");

                entity.Property(e => e.BankJvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BankJVDate");

                entity.Property(e => e.BatchDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimAbnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ClaimABNumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("For Perfect Store Damage");

                entity.Property(e => e.ClaimNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimPercentage).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ClaimSendId).HasColumnName("ClaimSendID");

                entity.Property(e => e.ClaimSetteledTypeId)
                    .HasColumnName("ClaimSetteledTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CostCenterId)
                    .HasColumnName("CostCenterID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerJvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CustomerJVDate");

                entity.Property(e => e.DamageAbnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DamageABNumber");

                entity.Property(e => e.DamageCbt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DamageCBT");

                entity.Property(e => e.DepotApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.DepotCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Enrolled).HasDefaultValueSql("((0))");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FromDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GlaccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLAccountNo")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsBankJv).HasColumnName("IsBankJV");

                entity.Property(e => e.IsCustomerJv).HasColumnName("IsCustomerJV");

                entity.Property(e => e.IsJvcreate).HasColumnName("IsJVCreate");

                entity.Property(e => e.IsJvcreateDamageQty).HasColumnName("IsJVCreateDamageQty");

                entity.Property(e => e.IsVendorJv).HasColumnName("IsVendorJV");

                entity.Property(e => e.JvcreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JVCreateDate");

                entity.Property(e => e.JvdamageDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JVDamageDate");

                entity.Property(e => e.ManualBatchDate).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Obdno)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OBDNo")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OutletCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PreviousBatchDate).HasColumnType("datetime");

                entity.Property(e => e.PreviousBatchNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reason)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soasteps)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SOASteps")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.Property(e => e.VendorJvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("VendorJVDate");

                entity.Property(e => e.Winner).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkflowUserId).HasColumnName("WorkflowUserID");
            });

            modelBuilder.Entity<ArchiveClaimNsddetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ArchiveClaimNSDDetail");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DelivaryNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GrossValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ListPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PromotionFlag).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOM")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ArchiveClaimP>(entity =>
            {
                entity.ToTable("ArchiveClaimPS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid)
                    .HasColumnName("ABID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftDescription)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProductCategory)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SlabName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<ArchiveClaimPollydut>(entity =>
            {
                entity.ToTable("ArchiveClaimPollydut");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid)
                    .HasColumnName("ABID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Achievement).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNewSystem)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Payout)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PollyduthName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Slab)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Target).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ArchiveClaimSendAsm>(entity =>
            {
                entity.ToTable("ArchiveClaimSendASM");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Asm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ASM");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.Tm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TM");
            });

            modelBuilder.Entity<AuthorizationUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AuthorizationUsers");

                entity.Property(e => e.AuthoUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AuthoUserID");

                entity.Property(e => e.AuthorizationLimits).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AuthorizationTypeId).HasColumnName("AuthorizationTypeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(154)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<AuthorizedAbdelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AuthorizedABDelete");

                entity.Property(e => e.AuthoriseDate).HasColumnType("datetime");

                entity.Property(e => e.AuthoriseDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AuthoriseText)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AuthoriseUser)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.AuthoriseUserId).HasColumnName("AuthoriseUserID");

                entity.Property(e => e.DeleteStatus)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.RequestDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RequestText)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RequestUser)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.RequestUserId).HasColumnName("RequestUserID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<AuthorizedAbview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AuthorizedABView");

                entity.Property(e => e.Abamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ABAmount");

                entity.Property(e => e.Abdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ABDate");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.AuthoriseUserId).HasColumnName("AuthoriseUserID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<AvailibilityComplainView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AvailibilityComplainView");

                entity.Property(e => e.ActionerComments)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Area)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AssignedEmployee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AssignedEmployeeEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AssignedEmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AssignedEmployeePhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Attachment)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Distributor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EntryUserEmployee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryUserEmployeeEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryUserEmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryUserEmployeePhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LandMark)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Market)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MarketId).HasColumnName("MarketID");

                entity.Property(e => e.MarketName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MatterDate).HasColumnType("datetime");

                entity.Property(e => e.MatterDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Products)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ReOpenDate).HasColumnType("datetime");

                entity.Property(e => e.Region)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RequesterComments)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StoreKeeperName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreKeeperPhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Territory)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateUserEmployee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateUserEmployeeEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateUserEmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateUserEmployeePhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<BaselineVolume>(entity =>
            {
                entity.ToTable("BaselineVolume");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.April).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.August).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.December).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.February).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.January).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.July).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.June).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.March).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.May).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.November).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.October).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ph9code)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph9name)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("PH9Name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.September).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<BudgetRatio>(entity =>
            {
                entity.ToTable("BudgetRatio");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.April).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.August).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.December).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.February).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.January).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.July).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.June).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.March).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.May).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.November).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.October).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ph10code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Code");

                entity.Property(e => e.Ph8code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code");

                entity.Property(e => e.Ph9code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code");

                entity.Property(e => e.Ratio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.September).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<BudgetRatioBmilocal>(entity =>
            {
                entity.ToTable("BudgetRatioBMILocal");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.April).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.August).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.December).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.February).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.January).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.July).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.June).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.March).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.May).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.November).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.October).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ph10code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Code");

                entity.Property(e => e.Ph8code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code");

                entity.Property(e => e.Ph9code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code");

                entity.Property(e => e.Ratio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.September).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<CcandGlaccountView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CCAndGLAccountView");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GlaccountNo)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("GLAccountNo");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Channel>(entity =>
            {
                entity.ToTable("Channel");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<ClaimAit>(entity =>
            {
                entity.ToTable("ClaimAIT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Aitamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AITAmount");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ClaimAits)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimAIT_ClaimMaster");
            });

            modelBuilder.Entity<ClaimAitprocessDay>(entity =>
            {
                entity.ToTable("ClaimAITProcessDay");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClaimMasterId).HasColumnName("ClaimMasterID");

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsJvcreate).HasColumnName("IsJVCreate");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<ClaimAitview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimAITView");

                entity.Property(e => e.Aitamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AITAmount");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<ClaimAllocationRule>(entity =>
            {
                entity.ToTable("ClaimAllocationRule");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MonthYear).HasDefaultValueSql("(CONVERT([int],CONVERT([varchar],datepart(year,getdate()),(0))+CONVERT([varchar],datepart(month,getdate()),(0)),(0)))");

                entity.Property(e => e.Percentage).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Target).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.HasOne(d => d.ClaimType)
                    .WithMany(p => p.ClaimAllocationRules)
                    .HasForeignKey(d => d.ClaimTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimAllocationRule_ValueList");
            });

            modelBuilder.Entity<ClaimAutoBatchCreationView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimAutoBatchCreationView");

                entity.Property(e => e.ClaimIds)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("ClaimIDs");

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");
            });

            modelBuilder.Entity<ClaimBacklitRate>(entity =>
            {
                entity.ToTable("ClaimBacklitRate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<ClaimBacklitTarget>(entity =>
            {
                entity.ToTable("ClaimBacklitTarget");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FromMonth)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutletCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OutletName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Route)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ToMonth)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ClaimBacklitTargetDataView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimBacklitTargetDataView");

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FromMonth).HasColumnType("datetime");

                entity.Property(e => e.FromMonthFormatted).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OutletCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OutletName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToMonth).HasColumnType("datetime");

                entity.Property(e => e.ToMonthFormatted).HasMaxLength(50);
            });

            modelBuilder.Entity<ClaimBudget>(entity =>
            {
                entity.ToTable("ClaimBudget");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AllocatedBudget).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedBudget).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasComment("ABID");

                entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ClaimBudgets)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimBudget_ABMaster");
            });

            modelBuilder.Entity<ClaimBudgetNoAb>(entity =>
            {
                entity.ToTable("ClaimBudgetNoAB");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActivityEndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ActivityStartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AmendAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimBudget).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.CutOffDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.HasOne(d => d.ClaimType)
                    .WithMany(p => p.ClaimBudgetNoAbs)
                    .HasForeignKey(d => d.ClaimTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimBudgetNoAB_ValueList");
            });

            modelBuilder.Entity<ClaimBudgetView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimBudgetView");

                entity.Property(e => e.AllocatedBudget).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AllocatedBudgetMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBudget).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedBudgetMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ClaimCategoryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimCategoryView");

                entity.Property(e => e.ClaimCategoryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimTypeId)
                    .HasMaxLength(78)
                    .IsUnicode(false)
                    .HasColumnName("ClaimTypeID");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<ClaimCategoryWiseClaimType>(entity =>
            {
                entity.ToTable("ClaimCategoryWiseClaimType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClaimCategoryId).HasColumnName("ClaimCategoryID");

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");
            });

            modelBuilder.Entity<ClaimCdfmdatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimCDFMData");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.FromEmployeeId).HasColumnName("FromEmployeeID");

                entity.Property(e => e.FromEmployeeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InitiatorId).HasColumnName("InitiatorID");

                entity.Property(e => e.InitiatorName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RequisitionId).HasColumnName("RequisitionID");

                entity.Property(e => e.RequisitionNo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitDate).HasColumnType("datetime");

                entity.Property(e => e.ToEmployeeId).HasColumnName("ToEmployeeID");

                entity.Property(e => e.ToEmployeeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WfsetupDetailId).HasColumnName("WFSetupDetailID");

                entity.Property(e => e.WfsetupMasterId).HasColumnName("WFSetupMasterID");
            });

            modelBuilder.Entity<ClaimClarificationHistory>(entity =>
            {
                entity.ToTable("ClaimClarificationHistory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClaimMasterId).HasColumnName("ClaimMasterID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromEmployee)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FromEmployeeId).HasColumnName("FromEmployeeID");

                entity.Property(e => e.FromUserComments)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.FromUserTypeId).HasColumnName("FromUserTypeID");

                entity.Property(e => e.ReplayDate).HasColumnType("datetime");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.ToEmployee)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ToEmployeeId).HasColumnName("ToEmployeeID");

                entity.Property(e => e.ToUserComments)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ToUserTypeId).HasColumnName("ToUserTypeID");
            });

            modelBuilder.Entity<ClaimClarificationHistoryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimClarificationHistoryView");

                entity.Property(e => e.ClaimMasterId).HasColumnName("ClaimMasterID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.FromEmployee)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FromEmployeeId).HasColumnName("FromEmployeeID");

                entity.Property(e => e.FromUserComments)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.FromUserType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FromUserTypeId).HasColumnName("FromUserTypeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Replay)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ReplayDate).HasColumnType("datetime");

                entity.Property(e => e.ReplayDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Send)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.SendDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ToEmployee)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ToEmployeeId).HasColumnName("ToEmployeeID");

                entity.Property(e => e.ToUserComments)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ToUserType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ToUserTypeId).HasColumnName("ToUserTypeID");
            });

            modelBuilder.Entity<ClaimClp>(entity =>
            {
                entity.ToTable("ClaimCLP");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid)
                    .HasColumnName("ABID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GiftRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNewSystem)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Payout)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Slab)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ClaimClps)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimCLP_ClaimMaster");
            });

            modelBuilder.Entity<ClaimClpview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimCLPView");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GiftRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Payout)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Slab)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<ClaimCmdistributorEmployee>(entity =>
            {
                entity.ToTable("ClaimCMDistributorEmployee");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Education)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InactiveDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaimCmgradeCategory>(entity =>
            {
                entity.ToTable("ClaimCMGradeCategory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Da)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DA");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalaryStructureId).HasColumnName("SalaryStructureID");

                entity.Property(e => e.Ta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TA");

                entity.HasOne(d => d.SalaryStructure)
                    .WithMany(p => p.ClaimCmgradeCategories)
                    .HasForeignKey(d => d.SalaryStructureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimCMGradeCategory_ClaimCMSalaryStructure");
            });

            modelBuilder.Entity<ClaimCmhopidatum>(entity =>
            {
                entity.ToTable("ClaimCMHOPIData");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ClaimCmhopisetup>(entity =>
            {
                entity.ToTable("ClaimCMHOPISetup");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinPercentage).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ClaimCmlopidatum>(entity =>
            {
                entity.ToTable("ClaimCMLOPIData");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkingDays).HasDefaultValueSql("((26))");
            });

            modelBuilder.Entity<ClaimCmsalary>(entity =>
            {
                entity.ToTable("ClaimCMSalary");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Da)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DA");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Hopi)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("HOPI");

                entity.Property(e => e.Lopi)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LOPI");

                entity.Property(e => e.Ta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TA");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ClaimCmsalaryStructure>(entity =>
            {
                entity.ToTable("ClaimCMSalaryStructure");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bonus).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Da)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DA");

                entity.Property(e => e.EffectDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.Hopi)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("HOPI");

                entity.Property(e => e.Lopi)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LOPI");

                entity.Property(e => e.Ta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TA");

                entity.Property(e => e.TillDate).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ClaimCmsalaryStructureCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimCMSalaryStructure_Category");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.ClaimCmsalaryStructureGrades)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimCMSalaryStructure_Grade");
            });

            modelBuilder.Entity<ClaimComment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CommentsDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<ClaimCostCenter>(entity =>
            {
                entity.ToTable("ClaimCostCenter");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ClaimCoupon>(entity =>
            {
                entity.ToTable("ClaimCoupon");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid)
                    .HasColumnName("ABID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GiftRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNewSystem)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Payout)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Slab)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<ClaimCouponView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimCouponView");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GiftRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Payout)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Slab)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<ClaimCpp>(entity =>
            {
                entity.ToTable("ClaimCPP");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FreeSkucase).HasColumnName("FreeSKUCase");

                entity.Property(e => e.FreeSkucode)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("FreeSKUCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FreeSkuname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FreeSKUName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FreeSkuunit).HasColumnName("FreeSKUUnit");

                entity.Property(e => e.MasterSkuname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MasterSKUName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PromotionCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Skucase).HasColumnName("SKUCase");

                entity.Property(e => e.Skucode)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("SKUCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Skuunit).HasColumnName("SKUUnit");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ClaimCpps)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimCPP_ClaimMaster");
            });

            modelBuilder.Entity<ClaimDamage>(entity =>
            {
                entity.ToTable("ClaimDamage");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClaimAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("IF Place = C or D, then ClaimPrice * (SKUCase * PackSize) + SKUUnit else TradePrice * (SKUCase * PackSize) + SKUUnit");

                entity.Property(e => e.ClaimPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DamageReason)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DefectCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DefectDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InitialQuantity).HasComment("(SKUCase * PackSize) + SKUUnit");

                entity.Property(e => e.IsNsd).HasColumnName("IsNSD");

                entity.Property(e => e.ListPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Skucase).HasColumnName("SKUCase");

                entity.Property(e => e.Skucode)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("SKUCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Skuname)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SKUName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Skuunit).HasColumnName("SKUUnit");

                entity.Property(e => e.TradePrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ClaimDamages)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDamage_ClaimMaster");
            });

            modelBuilder.Entity<ClaimDamageClarificationHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimDamageClarificationHistory");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.BankJvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BankJVDate");

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimAbnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ClaimABNumber");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimCategoryId).HasColumnName("ClaimCategoryID");

                entity.Property(e => e.ClaimDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimFromDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimMasterId).HasColumnName("ClaimMasterID");

                entity.Property(e => e.ClaimNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimPercentage).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ClaimSendId).HasColumnName("ClaimSendID");

                entity.Property(e => e.ClaimToDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerJvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CustomerJVDate");

                entity.Property(e => e.DepotCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EmptyComments)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.ErrorMessage).HasColumnType("text");

                entity.Property(e => e.ForOrderBy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.FromDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsBankJv).HasColumnName("IsBankJV");

                entity.Property(e => e.IsCustomerJv).HasColumnName("IsCustomerJV");

                entity.Property(e => e.IsJvcreate).HasColumnName("IsJVCreate");

                entity.Property(e => e.IsJvcreateDamageQty).HasColumnName("IsJVCreateDamageQty");

                entity.Property(e => e.IsVendorJv).HasColumnName("IsVendorJV");

                entity.Property(e => e.Message)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Obdno)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OBDNo");

                entity.Property(e => e.OutletCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramMonth)
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonDescription)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Soasteps)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SOASteps");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDetail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.ToDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ToEmployeeId).HasColumnName("ToEmployeeID");

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TownName1)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.Property(e => e.VendorJvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("VendorJVDate");

                entity.Property(e => e.WorkflowUserId).HasColumnName("WorkflowUserID");

                entity.Property(e => e.YtddamageAmount).HasColumnName("YTDDamageAmount");
            });

            modelBuilder.Entity<ClaimDamageNsd>(entity =>
            {
                entity.ToTable("ClaimDamageNSD");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClaimAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("IF Place = C or D, then ClaimPrice * (SKUCase * PackSize) + SKUUnit else TradePrice * (SKUCase * PackSize) + SKUUnit");

                entity.Property(e => e.ClaimPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DamageReason)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DefectCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DefectDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InitialQuantity).HasComment("(SKUCase * PackSize) + SKUUnit");

                entity.Property(e => e.IsNsd).HasColumnName("IsNSD");

                entity.Property(e => e.ListPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Skucase).HasColumnName("SKUCase");

                entity.Property(e => e.Skucode)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("SKUCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Skuname)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SKUName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Skuunit).HasColumnName("SKUUnit");

                entity.Property(e => e.TradePrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ClaimDamageOmr>(entity =>
            {
                entity.ToTable("ClaimDamageOMR");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BillingDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BillingDocument)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DefectCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Delivery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryDateInt).HasDefaultValueSql("((1))");

                entity.Property(e => e.EntryDateStr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.Material)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NetPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderCreationDate)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PackSizeDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Plant)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PoNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesDocument)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToParty)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoldName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SoldToParty)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaimDamageOmrarchive>(entity =>
            {
                entity.ToTable("ClaimDamageOMRArchive");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BillingDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BillingDocument)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DefectCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Delivery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryDateInt).HasDefaultValueSql("((1))");

                entity.Property(e => e.EntryDateStr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.Material)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NetPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderCreationDate)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PackSizeDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Plant)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PoNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesDocument)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToParty)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoldName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SoldToParty)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaimDamageReason>(entity =>
            {
                entity.ToTable("ClaimDamageReason");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(550)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<ClaimDamageView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimDamageView");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DamageReason)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DefectCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DefectDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsNsd).HasColumnName("IsNSD");

                entity.Property(e => e.ListPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ParentDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Skucase).HasColumnName("SKUCase");

                entity.Property(e => e.Skucode)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("SKUCode");

                entity.Property(e => e.Skuname)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SKUName");

                entity.Property(e => e.Skuunit).HasColumnName("SKUUnit");

                entity.Property(e => e.TradePrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ClaimDd>(entity =>
            {
                entity.ToTable("ClaimDD");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FreeSkucase).HasColumnName("FreeSKUCase");

                entity.Property(e => e.FreeSkucode)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("FreeSKUCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FreeSkuname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FreeSKUName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FreeSkuunit).HasColumnName("FreeSKUUnit");

                entity.Property(e => e.MasterSkuname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MasterSKUName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PromotionCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Skucase).HasColumnName("SKUCase");

                entity.Property(e => e.Skucode)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("SKUCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Skuunit).HasColumnName("SKUUnit");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ClaimDds)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDD_ClaimMaster");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ClaimDds)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDD_ValueList");
            });

            modelBuilder.Entity<ClaimDdview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimDDView");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FreeSkucase).HasColumnName("FreeSKUCase");

                entity.Property(e => e.FreeSkucode)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("FreeSKUCode");

                entity.Property(e => e.FreeSkuname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FreeSKUName");

                entity.Property(e => e.FreeSkuunit).HasColumnName("FreeSKUUnit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MasterSkuname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MasterSKUName");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PromotionCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Skucase).HasColumnName("SKUCase");

                entity.Property(e => e.Skucode)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("SKUCode");

                entity.Property(e => e.Skuunit).HasColumnName("SKUUnit");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<ClaimDepotMapping>(entity =>
            {
                entity.ToTable("ClaimDepotMapping");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepotCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.ParentCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<ClaimDff>(entity =>
            {
                entity.ToTable("ClaimDFF");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Achievement).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorGrade)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InitialClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsNewSystem)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Kpiname)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("KPIName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProgramCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Target).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ClaimDffs)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDFF_ClaimMaster");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ClaimDffs)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDFF_ValueList");
            });

            modelBuilder.Entity<ClaimDffview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimDFFView");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.Achievement).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorGrade)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InitialClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Kpiname)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("KPIName");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProgramCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Target).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ClaimDi>(entity =>
            {
                entity.ToTable("ClaimDI");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ClaimDis)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDI_ClaimMaster");
            });

            modelBuilder.Entity<ClaimDidistributorGroup>(entity =>
            {
                entity.ToTable("ClaimDIDistributorGroup");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GradeGroupId).HasColumnName("GradeGroupID");

                entity.HasOne(d => d.GradeGroup)
                    .WithMany(p => p.ClaimDidistributorGroups)
                    .HasForeignKey(d => d.GradeGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDIDistributorGroup_ClaimDIGradeGroup");
            });

            modelBuilder.Entity<ClaimDidistributorGroupView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimDIDistributorGroupView");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Grade)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GradeGroup)
                    .IsRequired()
                    .HasMaxLength(205)
                    .IsUnicode(false);

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Groups)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<ClaimDidistributorPscomplaince>(entity =>
            {
                entity.ToTable("ClaimDIDistributorPSComplaince");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Complaince).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ClaimDidistributorPstarget>(entity =>
            {
                entity.ToTable("ClaimDIDistributorPSTarget");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Target).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ClaimDidistributorSkutarget>(entity =>
            {
                entity.ToTable("ClaimDIDistributorSKUTarget");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ListPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("get from necleus");

                entity.Property(e => e.MaterialCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaterialName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Target).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TargetValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("TargetValue = LP * Target");
            });

            modelBuilder.Entity<ClaimDidistributorTarget>(entity =>
            {
                entity.ToTable("ClaimDIDistributorTarget");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Target).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ClaimDigradeGroup>(entity =>
            {
                entity.ToTable("ClaimDIGradeGroup");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.ClaimDigradeGroupGrades)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDIGradeGroup_Grade");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ClaimDigradeGroupGroups)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimGroupDistributor_Group");
            });

            modelBuilder.Entity<ClaimDiincentiveSetup>(entity =>
            {
                entity.ToTable("ClaimDIIncentiveSetup");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FlatAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GradeGroupId).HasColumnName("GradeGroupID");

                entity.Property(e => e.Incentive).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.SlabId).HasColumnName("SlabID");

                entity.HasOne(d => d.GradeGroup)
                    .WithMany(p => p.ClaimDiincentiveSetups)
                    .HasForeignKey(d => d.GradeGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDIIncentiveSetup_ClaimDIGradeGroup");

                entity.HasOne(d => d.Param)
                    .WithMany(p => p.ClaimDiincentiveSetups)
                    .HasForeignKey(d => d.ParamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDIIncentiveSetup_ClaimDIParamMaster");

                entity.HasOne(d => d.Slab)
                    .WithMany(p => p.ClaimDiincentiveSetups)
                    .HasForeignKey(d => d.SlabId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDIIncentiveSetup_ClaimDIParamSlab");
            });

            modelBuilder.Entity<ClaimDiparamMaster>(entity =>
            {
                entity.ToTable("ClaimDIParamMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JoinTypeId)
                    .HasColumnName("JoinTypeID")
                    .HasComment("0-None,1-And,2=Or");

                entity.Property(e => e.ParamTypeId).HasColumnName("ParamTypeID");

                entity.Property(e => e.PhlevelId).HasColumnName("PHLevelID");

                entity.Property(e => e.SalesTypeId)
                    .HasColumnName("SalesTypeID")
                    .HasComment("0-None,1-Primary Sales,2-Secondary Sales");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.HasOne(d => d.JoinType)
                    .WithMany(p => p.ClaimDiparamMasterJoinTypes)
                    .HasForeignKey(d => d.JoinTypeId)
                    .HasConstraintName("FK_ClaimDIParamDetail_JoinType");

                entity.HasOne(d => d.ParamType)
                    .WithMany(p => p.ClaimDiparamMasterParamTypes)
                    .HasForeignKey(d => d.ParamTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDIParamDetail_ParamType");

                entity.HasOne(d => d.Phlevel)
                    .WithMany(p => p.ClaimDiparamMasterPhlevels)
                    .HasForeignKey(d => d.PhlevelId)
                    .HasConstraintName("FK_ClaimDIParamDetail_PHLevel");

                entity.HasOne(d => d.SalesType)
                    .WithMany(p => p.ClaimDiparamMasterSalesTypes)
                    .HasForeignKey(d => d.SalesTypeId)
                    .HasConstraintName("FK_ClaimDIParamDetail_ValueList");
            });

            modelBuilder.Entity<ClaimDiparamMasterView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimDIParamMasterView");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JoinType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JoinTypeId).HasColumnName("JoinTypeID");

                entity.Property(e => e.ParamType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParamTypeId).HasColumnName("ParamTypeID");

                entity.Property(e => e.Phlevel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PHLevel");

                entity.Property(e => e.PhlevelId).HasColumnName("PHLevelID");

                entity.Property(e => e.SalesType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTypeId).HasColumnName("SalesTypeID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<ClaimDiparamPh>(entity =>
            {
                entity.ToTable("ClaimDIParamPH");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ClaimDiparamPhs)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDIParamPH_ClaimDIParamMaster");
            });

            modelBuilder.Entity<ClaimDiparamSc>(entity =>
            {
                entity.ToTable("ClaimDIParamSC");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ClaimDiparamScs)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDIParamSC_ClaimDIParamMaster");
            });

            modelBuilder.Entity<ClaimDiparamSlab>(entity =>
            {
                entity.ToTable("ClaimDIParamSlab");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Maximum).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Minimum).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ClaimDiparamSlabs)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDIParamSlab_ClaimDIParamMaster");
            });

            modelBuilder.Entity<ClaimDiprimarySalesMonthly>(entity =>
            {
                entity.ToTable("ClaimDIPrimarySalesMonthly");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ListPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaterialCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaterialName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalesValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("SalesValue = LP * SalesVolume");

                entity.Property(e => e.SalesVolume).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ClaimDiprocessDatum>(entity =>
            {
                entity.ToTable("ClaimDIProcessData");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Acheivement).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AchivementAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.MaterialCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaterialName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaximumFlatAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaximumIncAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinimumFlatAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinimumIncAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParamMasterId).HasColumnName("ParamMasterID");

                entity.Property(e => e.ParamTypeId).HasColumnName("ParamTypeID");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.SlabId).HasColumnName("SlabID");

                entity.Property(e => e.Target).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TargetValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransferDate).HasColumnType("datetime");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.ClaimDiprocessDatumGrades)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDIProcessData_ValueList_Grade");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ClaimDiprocessDatumGroups)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDIProcessData_ValueList_Group");

                entity.HasOne(d => d.ParamMaster)
                    .WithMany(p => p.ClaimDiprocessData)
                    .HasForeignKey(d => d.ParamMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDIProcessData_ClaimDIParamMaster");

                entity.HasOne(d => d.ParamType)
                    .WithMany(p => p.ClaimDiprocessDatumParamTypes)
                    .HasForeignKey(d => d.ParamTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDIProcessData_ValueList_ParamType");

                entity.HasOne(d => d.Slab)
                    .WithMany(p => p.ClaimDiprocessData)
                    .HasForeignKey(d => d.SlabId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDIProcessData_ClaimDIParamSlab");
            });

            modelBuilder.Entity<ClaimDisecondarySalesMonthly>(entity =>
            {
                entity.ToTable("ClaimDISecondarySalesMonthly");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ListPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaterialCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaterialName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalesValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("SalesValue = LP * SalesVolume");

                entity.Property(e => e.SalesVolume).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ClaimDistributorPlant>(entity =>
            {
                entity.ToTable("ClaimDistributorPlant");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DepotCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepotName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlantSapcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PlantSAPCode");

                entity.Property(e => e.SalesRegion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaimDosti>(entity =>
            {
                entity.ToTable("ClaimDosti");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid)
                    .HasColumnName("ABID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNewSystem)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Payout)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Slab)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ClaimDostis)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimDosti_ClaimMaster");
            });

            modelBuilder.Entity<ClaimDostiView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimDostiView");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GiftRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Payout)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Slab)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<ClaimErrorLog>(entity =>
            {
                entity.ToTable("ClaimErrorLog");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimMasterId).HasColumnName("ClaimMasterID");

                entity.Property(e => e.ClaimNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ErrorProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProcessUserID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessUserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ClaimErrorLogView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimErrorLogView");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimCategoryId).HasColumnName("ClaimCategoryID");

                entity.Property(e => e.ClaimDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimMasterId).HasColumnName("ClaimMasterID");

                entity.Property(e => e.ClaimNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProcessUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProcessUserID");

                entity.Property(e => e.ProcessUserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaimJvddicollection>(entity =>
            {
                entity.ToTable("ClaimJVDDICollection");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimCategoryId).HasColumnName("ClaimCategoryID");

                entity.Property(e => e.ClaimMasterId).HasColumnName("ClaimMasterID");

                entity.Property(e => e.ClaimNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DebitAccountName)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DebitAccountNo)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaymentStatusDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentStatusId).HasColumnName("PaymentStatusID");

                entity.Property(e => e.ReferenceNo)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RoutingNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.PaymentStatus)
                    .WithMany(p => p.ClaimJvddicollections)
                    .HasForeignKey(d => d.PaymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimJVDDICollection_ValueList");
            });

            modelBuilder.Entity<ClaimJvpayment>(entity =>
            {
                entity.ToTable("ClaimJVPayment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimCategoryId).HasColumnName("ClaimCategoryID");

                entity.Property(e => e.ClaimMasterId).HasColumnName("ClaimMasterID");

                entity.Property(e => e.ClaimNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DebitAccountNo)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayeeBankAccountNo)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayeeEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayeeName)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentStatusDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentStatusId).HasColumnName("PaymentStatusID");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReferenceNo)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.PaymentStatus)
                    .WithMany(p => p.ClaimJvpayments)
                    .HasForeignKey(d => d.PaymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimJVPayment_ValueList");
            });

            modelBuilder.Entity<ClaimManual>(entity =>
            {
                entity.ToTable("ClaimManual");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Aitamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AITAmount");

                entity.Property(e => e.Aitid).HasColumnName("AITID");

                entity.Property(e => e.BatchDate).HasColumnType("datetime");

                entity.Property(e => e.BatchNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsPartialSettelement).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SetteledAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SetteledDate).HasColumnType("datetime");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ClaimManuals)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimManual_ClaimMaster");
            });

            modelBuilder.Entity<ClaimManualAit>(entity =>
            {
                entity.ToTable("ClaimManualAIT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Aitpercentage)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AITPercentage")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ClaimManualBatchPendingView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimManualBatchPendingView");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.Aitamount)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("AITAmount");

                entity.Property(e => e.BankJvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BankJVDate");

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimAbnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ClaimABNumber");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimCategoryId).HasColumnName("ClaimCategoryID");

                entity.Property(e => e.ClaimDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimFromDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimPercentage).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ClaimSendId).HasColumnName("ClaimSendID");

                entity.Property(e => e.ClaimSetteledTypeId).HasColumnName("ClaimSetteledTypeID");

                entity.Property(e => e.ClaimToDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.CustomerJvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CustomerJVDate");

                entity.Property(e => e.DepotCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EmptyComments)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.ErrorMessage).HasColumnType("text");

                entity.Property(e => e.ForOrderBy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.FromDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GlaccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLAccountNo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsBankJv).HasColumnName("IsBankJV");

                entity.Property(e => e.IsCustomerJv).HasColumnName("IsCustomerJV");

                entity.Property(e => e.IsJvcreate).HasColumnName("IsJVCreate");

                entity.Property(e => e.IsJvcreateDamageQty).HasColumnName("IsJVCreateDamageQty");

                entity.Property(e => e.IsVendorJv).HasColumnName("IsVendorJV");

                entity.Property(e => e.JvcreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JVCreateDate");

                entity.Property(e => e.JvdamageDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JVDamageDate");

                entity.Property(e => e.ManualStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Obdno)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OBDNo");

                entity.Property(e => e.OutletCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PendingClaimAmount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ProgramMonth)
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonDescription)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Soasteps)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SOASteps");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDetail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.ToDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TownName1)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.Property(e => e.VendorJvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("VendorJVDate");

                entity.Property(e => e.WorkFlowUserName)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowUserId).HasColumnName("WorkflowUserID");

                entity.Property(e => e.YtddamageAmount).HasColumnName("YTDDamageAmount");
            });

            modelBuilder.Entity<ClaimManualMaster>(entity =>
            {
                entity.ToTable("ClaimManualMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimGroup)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimReference)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimSpecificName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeductedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorClaimReference)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Reason)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RejectDate).HasColumnType("datetime");

                entity.Property(e => e.SettledAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SettledDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<ClaimManualView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimManualView");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.BankJvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BankJVDate");

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimAbnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ClaimABNumber");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimCategoryId).HasColumnName("ClaimCategoryID");

                entity.Property(e => e.ClaimDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimFromDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimPercentage).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ClaimSendId).HasColumnName("ClaimSendID");

                entity.Property(e => e.ClaimToDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.CustomerJvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CustomerJVDate");

                entity.Property(e => e.DepotCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EmptyComments)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.ErrorMessage).HasColumnType("text");

                entity.Property(e => e.ForOrderBy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.FromDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsBankJv).HasColumnName("IsBankJV");

                entity.Property(e => e.IsCustomerJv).HasColumnName("IsCustomerJV");

                entity.Property(e => e.IsJvcreate).HasColumnName("IsJVCreate");

                entity.Property(e => e.IsJvcreateDamageQty).HasColumnName("IsJVCreateDamageQty");

                entity.Property(e => e.IsVendorJv).HasColumnName("IsVendorJV");

                entity.Property(e => e.JvcreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JVCreateDate");

                entity.Property(e => e.JvdamageDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JVDamageDate");

                entity.Property(e => e.Message)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Obdno)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OBDNo");

                entity.Property(e => e.OutletCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramMonth)
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonDescription)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Soasteps)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SOASteps");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDetail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.ToDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TownName1)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.Property(e => e.VendorJvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("VendorJVDate");

                entity.Property(e => e.WorkFlowUserName)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowUserId).HasColumnName("WorkflowUserID");
            });

            modelBuilder.Entity<ClaimManualold>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClaimManualold");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimGroup)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimReference)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimSpecificName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeductedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorClaimReference)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RejectDate).HasColumnType("datetime");

                entity.Property(e => e.SettledAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SettledDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<ClaimMaster>(entity =>
            {
                entity.ToTable("ClaimMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid)
                    .HasColumnName("ABID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AbtypeId)
                    .HasColumnName("ABTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ait)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AIT");

                entity.Property(e => e.BankJvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BankJVDate");

                entity.Property(e => e.BatchDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimAbnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ClaimABNumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("For Perfect Store Damage");

                entity.Property(e => e.ClaimNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimPercentage).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ClaimSendId).HasColumnName("ClaimSendID");

                entity.Property(e => e.ClaimSetteledTypeId)
                    .HasColumnName("ClaimSetteledTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenterId)
                    .HasColumnName("CostCenterID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerJvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CustomerJVDate");

                entity.Property(e => e.DamageAbnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DamageABNumber");

                entity.Property(e => e.DamageCbt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DamageCBT");

                entity.Property(e => e.DepotApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.DepotCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Enrolled).HasDefaultValueSql("((0))");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FromDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GlaccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLAccountNo")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsBankJv).HasColumnName("IsBankJV");

                entity.Property(e => e.IsCustomerJv).HasColumnName("IsCustomerJV");

                entity.Property(e => e.IsJvcreate).HasColumnName("IsJVCreate");

                entity.Property(e => e.IsJvcreateDamageQty).HasColumnName("IsJVCreateDamageQty");

                entity.Property(e => e.IsVendorJv).HasColumnName("IsVendorJV");

                entity.Property(e => e.JvcreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JVCreateDate");

                entity.Property(e => e.JvdamageDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JVDamageDate");

                entity.Property(e => e.ManualBatchDate).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Obdno)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OBDNo")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OutletCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PreviousBatchDate).HasColumnType("datetime");

                entity.Property(e => e.PreviousBatchNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reason)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soasteps)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SOASteps")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.Property(e => e.VendorJvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("VendorJVDate");

                entity.Property(e => e.Winner).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkflowUserId).HasColumnName("WorkflowUserID");

                entity.HasOne(d => d.ClaimType)
                    .WithMany(p => p.ClaimMasterClaimTypes)
                    .HasForeignKey(d => d.ClaimTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimMaster_ValueList1");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ClaimMasterStatuses)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimMaster_ValueList");
            });

            modelBuilder.Entity<ClaimMasterView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimMasterView");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.Area)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankJvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BankJVDate");

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimAbnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ClaimABNumber");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimCategoryId).HasColumnName("ClaimCategoryID");

                entity.Property(e => e.ClaimDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimFromDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimPercentage).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ClaimSendId).HasColumnName("ClaimSendID");

                entity.Property(e => e.ClaimSetteledTypeId).HasColumnName("ClaimSetteledTypeID");

                entity.Property(e => e.ClaimToDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.CustomerJvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CustomerJVDate");

                entity.Property(e => e.DepotCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EmptyComments)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.ErrorMessage).HasColumnType("text");

                entity.Property(e => e.ForOrderBy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.FromDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GlaccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLAccountNo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsBankJv).HasColumnName("IsBankJV");

                entity.Property(e => e.IsCustomerJv).HasColumnName("IsCustomerJV");

                entity.Property(e => e.IsJvcreate).HasColumnName("IsJVCreate");

                entity.Property(e => e.IsJvcreateDamageQty).HasColumnName("IsJVCreateDamageQty");

                entity.Property(e => e.IsVendorJv).HasColumnName("IsVendorJV");

                entity.Property(e => e.JvcreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JVCreateDate");

                entity.Property(e => e.JvdamageDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JVDamageDate");

                entity.Property(e => e.ManualBatchDate).HasColumnType("datetime");

                entity.Property(e => e.ManualStatus)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Obdno)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OBDNo");

                entity.Property(e => e.OutletCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramMonth)
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonDescription)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Soasteps)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SOASteps");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDetail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Territory)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TerritoryCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.ToDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TownName1)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.Property(e => e.VendorJvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("VendorJVDate");

                entity.Property(e => e.WorkFlowUserName)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowUserId).HasColumnName("WorkflowUserID");

                entity.Property(e => e.YtddamageAmount).HasColumnName("YTDDamageAmount");
            });

            modelBuilder.Entity<ClaimMasterView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimMasterView1");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimAbnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ClaimABNumber");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimCategoryId).HasColumnName("ClaimCategoryID");

                entity.Property(e => e.ClaimDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimFromDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimPercentage).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ClaimSendId).HasColumnName("ClaimSendID");

                entity.Property(e => e.ClaimToDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DepotCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EmptyComments)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.ErrorMessage).HasColumnType("text");

                entity.Property(e => e.ForOrderBy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.FromDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsJvcreate).HasColumnName("IsJVCreate");

                entity.Property(e => e.IsJvcreateDamageQty).HasColumnName("IsJVCreateDamageQty");

                entity.Property(e => e.Obdno)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OBDNo");

                entity.Property(e => e.OutletCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonDescription)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Soasteps)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SOASteps");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDetail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.ToDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.Property(e => e.WorkflowUserId).HasColumnName("WorkflowUserID");

                entity.Property(e => e.YtddamageAmount).HasColumnName("YTDDamageAmount");
            });

            modelBuilder.Entity<ClaimMasterViewForDamage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimMasterViewForDamage");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimAbnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ClaimABNumber");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimCategoryId).HasColumnName("ClaimCategoryID");

                entity.Property(e => e.ClaimDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimFromDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimPercentage).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ClaimSendId).HasColumnName("ClaimSendID");

                entity.Property(e => e.ClaimToDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepotApprovedDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DepotCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EmptyComments)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.ErrorMessage).HasColumnType("text");

                entity.Property(e => e.ForOrderBy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.FromDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsJvcreate).HasColumnName("IsJVCreate");

                entity.Property(e => e.IsJvcreateDamageQty).HasColumnName("IsJVCreateDamageQty");

                entity.Property(e => e.Obdno)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OBDNo");

                entity.Property(e => e.OutletCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramMonth)
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RunningPercentage).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Soasteps)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SOASteps");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDetail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.ToDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TownName1)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.Property(e => e.WorkflowUserId).HasColumnName("WorkflowUserID");

                entity.Property(e => e.YtddamageAmount).HasColumnName("YTDDamageAmount");
            });

            modelBuilder.Entity<ClaimMasterViewForDamage1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimMasterViewForDamage1");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimAbnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ClaimABNumber");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimCategoryId).HasColumnName("ClaimCategoryID");

                entity.Property(e => e.ClaimDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimFromDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimPercentage).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ClaimSendId).HasColumnName("ClaimSendID");

                entity.Property(e => e.ClaimToDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DepotApprovedDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DepotCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EmptyComments)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.ErrorMessage).HasColumnType("text");

                entity.Property(e => e.ForOrderBy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.FromDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsJvcreate).HasColumnName("IsJVCreate");

                entity.Property(e => e.IsJvcreateDamageQty).HasColumnName("IsJVCreateDamageQty");

                entity.Property(e => e.Obdno)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OBDNo");

                entity.Property(e => e.OutletCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramMonth)
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RunningPercentage).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Soasteps)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SOASteps");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDetail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.ToDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TownName1)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.Property(e => e.WorkflowUserId).HasColumnName("WorkflowUserID");

                entity.Property(e => e.YtddamageAmount).HasColumnName("YTDDamageAmount");
            });

            modelBuilder.Entity<ClaimMasterViewForDamageMaterial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimMasterViewForDamageMaterial");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimAbnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ClaimABNumber");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimCategoryId).HasColumnName("ClaimCategoryID");

                entity.Property(e => e.ClaimDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimFromDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimPercentage).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ClaimSendId).HasColumnName("ClaimSendID");

                entity.Property(e => e.ClaimToDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DepotApprovedDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DepotCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EmptyComments)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.ErrorMessage).HasColumnType("text");

                entity.Property(e => e.ForOrderBy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.FromDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsJvcreate).HasColumnName("IsJVCreate");

                entity.Property(e => e.IsJvcreateDamageQty).HasColumnName("IsJVCreateDamageQty");

                entity.Property(e => e.Obdno)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OBDNo");

                entity.Property(e => e.OutletCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramMonth)
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RunningPercentage).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Soasteps)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SOASteps");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDetail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.ToDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TownName1)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.Property(e => e.WorkflowUserId).HasColumnName("WorkflowUserID");

                entity.Property(e => e.YtddamageAmount).HasColumnName("YTDDamageAmount");
            });

            modelBuilder.Entity<ClaimMtagreedMargin>(entity =>
            {
                entity.ToTable("ClaimMTAgreedMargin");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AgreedMonth)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AgreedPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CategoryCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IncrementalMargin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KeyAccountCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KeyAccountName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MarginPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MarginValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MrpsalesValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MRPSalesValue");

                entity.Property(e => e.TpsalesValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TPSalesValue");
            });

            modelBuilder.Entity<ClaimMtagreedMarginDataView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimMTAgreedMarginDataView");

                entity.Property(e => e.AgreedMonth).HasColumnType("datetime");

                entity.Property(e => e.AgreedMonthFormatted).HasMaxLength(50);

                entity.Property(e => e.AgreedPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CategoryCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IncrementalMargin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KeyAccountCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KeyAccountName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MarginPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MarginValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MrpsalesValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MRPSalesValue");

                entity.Property(e => e.TpsalesValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TPSalesValue");
            });

            modelBuilder.Entity<ClaimMtrate>(entity =>
            {
                entity.ToTable("ClaimMTRate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AgreedPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GondolaPosition)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeyAccountCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeyAccountName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OutletCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OutletName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalValue).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ClaimMtsecondarySale>(entity =>
            {
                entity.ToTable("ClaimMTSecondarySales");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CategoryCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaterialCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaterialName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OutletCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OutletName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RetailPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RetailValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TradePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TradeValue).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ClaimNsddetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClaimNSDDetail");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DelivaryNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GrossValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ListPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PromotionFlag).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOM")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Parent)
                    .WithMany()
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimNSDDetail_ClaimMaster");

                entity.HasOne(d => d.Status)
                    .WithMany()
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimNSDDetail_ValueList");
            });

            modelBuilder.Entity<ClaimP>(entity =>
            {
                entity.ToTable("ClaimPS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid)
                    .HasColumnName("ABID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftDescription)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProductCategory)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SlabName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ClaimPs)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimPS_ClaimMaster");
            });

            modelBuilder.Entity<ClaimPollydut>(entity =>
            {
                entity.ToTable("ClaimPollydut");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid)
                    .HasColumnName("ABID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Achievement).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNewSystem)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Payout)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PollyduthName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Slab)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Target).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ClaimPollyduts)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimPollydut_ClaimMaster");
            });

            modelBuilder.Entity<ClaimPollydutView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimPollydutView");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.Achievement).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GiftRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Payout)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PollyduthName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Slab)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Target).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ClaimPsview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimPSView");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.GiftAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiftDescription)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProductCategory)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SlabName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<ClaimRmdatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimRMData");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.FromEmployeeId).HasColumnName("FromEmployeeID");

                entity.Property(e => e.FromEmployeeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InitiatorId).HasColumnName("InitiatorID");

                entity.Property(e => e.InitiatorName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RequisitionId).HasColumnName("RequisitionID");

                entity.Property(e => e.RequisitionNo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitDate).HasColumnType("datetime");

                entity.Property(e => e.ToEmployeeId).HasColumnName("ToEmployeeID");

                entity.Property(e => e.ToEmployeeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WfsetupDetailId).HasColumnName("WFSetupDetailID");

                entity.Property(e => e.WfsetupMasterId).HasColumnName("WFSetupMasterID");
            });

            modelBuilder.Entity<ClaimSendAsm>(entity =>
            {
                entity.ToTable("ClaimSendASM");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Asm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ASM");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.Tm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TM");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ClaimSendAsms)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimSendASM_ClaimMaster");
            });

            modelBuilder.Entity<ClaimSoa>(entity =>
            {
                entity.ToTable("ClaimSOA");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClaimCategoryId).HasColumnName("ClaimCategoryID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MaxValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MinValue)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.HasOne(d => d.ClaimCategory)
                    .WithMany(p => p.ClaimSoaClaimCategories)
                    .HasForeignKey(d => d.ClaimCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimSOA_ValueList");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.ClaimSoaUserTypes)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimSOA_ValueList1");
            });

            modelBuilder.Entity<ClaimStorageLocation>(entity =>
            {
                entity.ToTable("ClaimStorageLocation");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.OrderReason)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorageLocation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaimTmdatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimTMData");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.FromEmployeeId).HasColumnName("FromEmployeeID");

                entity.Property(e => e.FromEmployeeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InitiatorId).HasColumnName("InitiatorID");

                entity.Property(e => e.InitiatorName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RequisitionId).HasColumnName("RequisitionID");

                entity.Property(e => e.RequisitionNo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitDate).HasColumnType("datetime");

                entity.Property(e => e.ToEmployeeId).HasColumnName("ToEmployeeID");

                entity.Property(e => e.ToEmployeeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WfsetupDetailId).HasColumnName("WFSetupDetailID");

                entity.Property(e => e.WfsetupMasterId).HasColumnName("WFSetupMasterID");
            });

            modelBuilder.Entity<ClaimTypeTag>(entity =>
            {
                entity.ToTable("ClaimTypeTag");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AbmoduleId).HasColumnName("ABModuleID");

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.HasOne(d => d.Abmodule)
                    .WithMany(p => p.ClaimTypeTags)
                    .HasForeignKey(d => d.AbmoduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimTypeTag_Module");

                entity.HasOne(d => d.ClaimType)
                    .WithMany(p => p.ClaimTypeTags)
                    .HasForeignKey(d => d.ClaimTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaimTypeTag_ValueList");
            });

            modelBuilder.Entity<ClaimVatpdomrappoveInfo>(entity =>
            {
                entity.ToTable("ClaimVATPDOMRAppoveInfo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ApprovedBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.BatchDetail)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNo).HasDefaultValueSql("('')");

                entity.Property(e => e.BatchStatusId).HasColumnName("BatchStatusID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemComments)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");
            });

            modelBuilder.Entity<Clearance>(entity =>
            {
                entity.ToTable("Clearance");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubmissionTypeId).HasColumnName("SubmissionTypeID");

                entity.Property(e => e.SubmitDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ClosingFinancialView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClosingFinancialView");

                entity.Property(e => e.Abdescription)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ABDescription");

                entity.Property(e => e.ActualAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.April).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AprilYtd)
                    .HasColumnType("decimal(21, 2)")
                    .HasColumnName("AprilYTD");

                entity.Property(e => e.August).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AugustYtd)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("AugustYTD");

                entity.Property(e => e.BudgetSubHead)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Cbt)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CBT");

                entity.Property(e => e.December).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DecemberYtd)
                    .HasColumnType("decimal(29, 2)")
                    .HasColumnName("DecemberYTD");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.February).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FebruaryYtd)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("FebruaryYTD");

                entity.Property(e => e.FirstHalf).HasColumnType("decimal(23, 2)");

                entity.Property(e => e.FirstHalfYtd)
                    .HasColumnType("decimal(23, 2)")
                    .HasColumnName("FirstHalfYTD");

                entity.Property(e => e.Initiator)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ioamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IOAmount");

                entity.Property(e => e.Ioid).HasColumnName("IOID");

                entity.Property(e => e.Ionumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("IONumber");

                entity.Property(e => e.January).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JanuaryYtd)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("JanuaryYTD");

                entity.Property(e => e.July).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JulyYtd)
                    .HasColumnType("decimal(24, 2)")
                    .HasColumnName("JulyYTD");

                entity.Property(e => e.June).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JuneYtd)
                    .HasColumnType("decimal(23, 2)")
                    .HasColumnName("JuneYTD");

                entity.Property(e => e.March).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MarchYtd)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("MarchYTD");

                entity.Property(e => e.May).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MayYtd)
                    .HasColumnType("decimal(22, 2)")
                    .HasColumnName("MayYTD");

                entity.Property(e => e.November).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NovemberYtd)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("NovemberYTD");

                entity.Property(e => e.October).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OctoberYtd)
                    .HasColumnType("decimal(27, 2)")
                    .HasColumnName("OctoberYTD");

                entity.Property(e => e.Q1total)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("Q1Total");

                entity.Property(e => e.Q1totalYtd)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("Q1TotalYTD");

                entity.Property(e => e.Q2total)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("Q2Total");

                entity.Property(e => e.Q2totalYtd)
                    .HasColumnType("decimal(23, 2)")
                    .HasColumnName("Q2TotalYTD");

                entity.Property(e => e.Q3total)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("Q3Total");

                entity.Property(e => e.Q3totalYtd)
                    .HasColumnType("decimal(26, 2)")
                    .HasColumnName("Q3TotalYTD");

                entity.Property(e => e.Q4total)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("Q4Total");

                entity.Property(e => e.Q4totalYtd)
                    .HasColumnType("decimal(29, 2)")
                    .HasColumnName("Q4TotalYTD");

                entity.Property(e => e.SecondHalf).HasColumnType("decimal(23, 2)");

                entity.Property(e => e.SecondHalfYtd)
                    .HasColumnType("decimal(29, 2)")
                    .HasColumnName("SecondHalfYTD");

                entity.Property(e => e.September).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SeptemberYtd)
                    .HasColumnType("decimal(26, 2)")
                    .HasColumnName("SeptemberYTD");

                entity.Property(e => e.StartDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.YearlyTotal).HasColumnType("decimal(29, 2)");

                entity.Property(e => e.YearlyTotalYtd)
                    .HasColumnType("decimal(29, 2)")
                    .HasColumnName("YearlyTotalYTD");
            });

            modelBuilder.Entity<ClosingIoListView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClosingIoListView");

                entity.Property(e => e.ActualAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Charge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChargeBalance).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Initiator)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ioamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IOAmount");

                entity.Property(e => e.Ioid).HasColumnName("IOID");

                entity.Property(e => e.Ionumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("IONumber");

                entity.Property(e => e.Jv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("JV");

                entity.Property(e => e.PnLcbt)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PnLCBT");

                entity.Property(e => e.ProvBalance).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.StartDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ytd)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("YTD");
            });

            modelBuilder.Entity<ClosingIoallocationRuleView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClosingIOAllocationRuleView");

                entity.Property(e => e.Abdescription)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ABDescription");

                entity.Property(e => e.AllocationRule).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ioid).HasColumnName("IOID");

                entity.Property(e => e.Ionumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("IONumber");

                entity.Property(e => e.Ph9code)
                    .HasMaxLength(51)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code");

                entity.Property(e => e.StartDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClosingIocbt>(entity =>
            {
                entity.ToTable("ClosingIOCBT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ioid).HasColumnName("IOID");

                entity.Property(e => e.PnLcbt)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PnLCBT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ytdamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("YTDAmount");

                entity.HasOne(d => d.Io)
                    .WithMany(p => p.ClosingIocbts)
                    .HasForeignKey(d => d.Ioid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClosingIOCBT_ClosingIOMaster");
            });

            modelBuilder.Entity<ClosingIocbtdataView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClosingIOCBTDataView");

                entity.Property(e => e.ChargeCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ioid).HasColumnName("IOID");

                entity.Property(e => e.PaymentCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PnLcbt)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PnLCBT");

                entity.Property(e => e.ProvisionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProvisionDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ytdamount)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("YTDAmount");
            });

            modelBuilder.Entity<ClosingIodetail>(entity =>
            {
                entity.ToTable("ClosingIODetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.AprilCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AprilJv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AprilJV");

                entity.Property(e => e.AprilYtd)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AprilYTD");

                entity.Property(e => e.AugustCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AugustJv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AugustJV");

                entity.Property(e => e.AugustYtd)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AugustYTD");

                entity.Property(e => e.DecemberCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DecemberJv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DecemberJV");

                entity.Property(e => e.DecemberYtd)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DecemberYTD");

                entity.Property(e => e.FebruaryCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FebruaryJv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FebruaryJV");

                entity.Property(e => e.FebruaryYtd)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FebruaryYTD");

                entity.Property(e => e.Ioid).HasColumnName("IOID");

                entity.Property(e => e.IsChargeCbt).HasColumnName("IsChargeCBT");

                entity.Property(e => e.IsJvcreate).HasColumnName("IsJVCreate");

                entity.Property(e => e.JanuaryCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JanuaryJv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("JanuaryJV");

                entity.Property(e => e.JanuaryYtd)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("JanuaryYTD");

                entity.Property(e => e.JulyCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JulyJv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("JulyJV");

                entity.Property(e => e.JulyYtd)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("JulyYTD");

                entity.Property(e => e.JuneCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JuneJv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("JuneJV");

                entity.Property(e => e.JuneYtd)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("JuneYTD");

                entity.Property(e => e.JvcreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JVCreateDate");

                entity.Property(e => e.Jvnumber).HasColumnName("JVNumber");

                entity.Property(e => e.MarchCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MarchJv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MarchJV");

                entity.Property(e => e.MarchYtd)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MarchYTD");

                entity.Property(e => e.MayCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MayJv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MayJV");

                entity.Property(e => e.MayYtd)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MayYTD");

                entity.Property(e => e.NovemberCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NovemberJv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NovemberJV");

                entity.Property(e => e.NovemberYtd)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NovemberYTD");

                entity.Property(e => e.OctoberCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OctoberJv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OctoberJV");

                entity.Property(e => e.OctoberYtd)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OctoberYTD");

                entity.Property(e => e.PnLcbt)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PnLCBT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProvisionCbt)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ProvisionCBT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SeptemberCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SeptemberJv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SeptemberJV");

                entity.Property(e => e.SeptemberYtd)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SeptemberYTD");

                entity.HasOne(d => d.Io)
                    .WithMany(p => p.ClosingIodetails)
                    .HasForeignKey(d => d.Ioid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClosingIODetail_ClosingIOMaster");
            });

            modelBuilder.Entity<ClosingIomaster>(entity =>
            {
                entity.ToTable("ClosingIOMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Abtype).HasColumnName("ABType");

                entity.Property(e => e.ActivityEndDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityStartDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.ActualAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BudgetSubHead)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.Initiator)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ioamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IOAmount");

                entity.Property(e => e.Ionumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("IONumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<ClosingIomasterView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClosingIOMasterView");

                entity.Property(e => e.Ab)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("AB");

                entity.Property(e => e.Abdescription)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ABDescription");

                entity.Property(e => e.ActivityType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ActualAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChargeBalance).HasColumnType("numeric(22, 4)");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Initiator)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Io)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("IO");

                entity.Property(e => e.Ioamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IOAMount");

                entity.Property(e => e.Ioid).HasColumnName("IOID");

                entity.Property(e => e.Iorule)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("IORule");

                entity.Property(e => e.ProvBalance).HasColumnType("numeric(21, 4)");

                entity.Property(e => e.StartDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ytdcharge)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("YTDCharge");
            });

            modelBuilder.Entity<ClosingIorule>(entity =>
            {
                entity.ToTable("ClosingIORule");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AllocationRule).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ioid).HasColumnName("IOID");

                entity.Property(e => e.Ph9code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Io)
                    .WithMany(p => p.ClosingIorules)
                    .HasForeignKey(d => d.Ioid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClosingIORule_ClosingIOMaster");
            });

            modelBuilder.Entity<ClosingProcessedDataView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClosingProcessedDataView");

                entity.Property(e => e.April).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AprilYtd)
                    .HasColumnType("decimal(21, 2)")
                    .HasColumnName("AprilYTD");

                entity.Property(e => e.August).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AugustYtd)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("AugustYTD");

                entity.Property(e => e.December).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DecemberYtd)
                    .HasColumnType("decimal(29, 2)")
                    .HasColumnName("DecemberYTD");

                entity.Property(e => e.February).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FebruaryYtd)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("FebruaryYTD");

                entity.Property(e => e.FirstHalf).HasColumnType("decimal(23, 2)");

                entity.Property(e => e.FirstHalfYtd)
                    .HasColumnType("decimal(23, 2)")
                    .HasColumnName("FirstHalfYTD");

                entity.Property(e => e.January).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JanuaryYtd)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("JanuaryYTD");

                entity.Property(e => e.July).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JulyYtd)
                    .HasColumnType("decimal(24, 2)")
                    .HasColumnName("JulyYTD");

                entity.Property(e => e.June).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JuneYtd)
                    .HasColumnType("decimal(23, 2)")
                    .HasColumnName("JuneYTD");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.March).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MarchYtd)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("MarchYTD");

                entity.Property(e => e.May).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MayYtd)
                    .HasColumnType("decimal(22, 2)")
                    .HasColumnName("MayYTD");

                entity.Property(e => e.MeasureCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeasureDescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MeasureId).HasColumnName("MeasureID");

                entity.Property(e => e.November).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NovemberYtd)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("NovemberYTD");

                entity.Property(e => e.October).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OctoberYtd)
                    .HasColumnType("decimal(27, 2)")
                    .HasColumnName("OctoberYTD");

                entity.Property(e => e.Ph0code)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PH0Code");

                entity.Property(e => e.Ph0name)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("PH0Name");

                entity.Property(e => e.Ph1code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1Code");

                entity.Property(e => e.Ph1name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1Name");

                entity.Property(e => e.Ph2code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2Code");

                entity.Property(e => e.Ph2name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2Name");

                entity.Property(e => e.Ph3code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3Code");

                entity.Property(e => e.Ph3name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3Name");

                entity.Property(e => e.Ph4code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4Code");

                entity.Property(e => e.Ph4name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4Name");

                entity.Property(e => e.Ph5code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Code");

                entity.Property(e => e.Ph5name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Name");

                entity.Property(e => e.Ph6code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH6Code");

                entity.Property(e => e.Ph6name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH6Name");

                entity.Property(e => e.Ph7code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH7Code");

                entity.Property(e => e.Ph7name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH7Name");

                entity.Property(e => e.Ph8code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code");

                entity.Property(e => e.Ph8name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Name");

                entity.Property(e => e.Ph9code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code");

                entity.Property(e => e.Ph9name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Name");

                entity.Property(e => e.Q1total)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("Q1Total");

                entity.Property(e => e.Q1totalYtd)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("Q1TotalYTD");

                entity.Property(e => e.Q2total)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("Q2Total");

                entity.Property(e => e.Q2totalYtd)
                    .HasColumnType("decimal(23, 2)")
                    .HasColumnName("Q2TotalYTD");

                entity.Property(e => e.Q3total)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("Q3Total");

                entity.Property(e => e.Q3totalYtd)
                    .HasColumnType("decimal(26, 2)")
                    .HasColumnName("Q3TotalYTD");

                entity.Property(e => e.Q4total)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("Q4Total");

                entity.Property(e => e.Q4totalYtd)
                    .HasColumnType("decimal(29, 2)")
                    .HasColumnName("Q4TotalYTD");

                entity.Property(e => e.SecondHalf).HasColumnType("decimal(23, 2)");

                entity.Property(e => e.SecondHalfYtd)
                    .HasColumnType("decimal(29, 2)")
                    .HasColumnName("SecondHalfYTD");

                entity.Property(e => e.September).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SeptemberYtd)
                    .HasColumnType("decimal(26, 2)")
                    .HasColumnName("SeptemberYTD");

                entity.Property(e => e.YearlyTotal).HasColumnType("decimal(29, 2)");

                entity.Property(e => e.YearlyTotalYtd)
                    .HasColumnType("decimal(29, 2)")
                    .HasColumnName("YearlyTotalYTD");
            });

            modelBuilder.Entity<ClosingProcessedDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.April).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.August).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.December).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.February).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ioid).HasColumnName("IOID");

                entity.Property(e => e.January).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.July).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.June).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.March).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.May).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MeasureCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MeasureDescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MeasureId).HasColumnName("MeasureID");

                entity.Property(e => e.November).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.October).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ph9code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code");

                entity.Property(e => e.September).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<CmgradeCategoryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CMGradeCategoryView");

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bonus).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Da)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DA");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.Grade)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GradeCategory)
                    .IsRequired()
                    .HasMaxLength(205)
                    .IsUnicode(false);

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.Hopi)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("HOPI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lopi)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LOPI");

                entity.Property(e => e.SalaryDa)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SalaryDA");

                entity.Property(e => e.SalaryStructureId).HasColumnName("SalaryStructureID");

                entity.Property(e => e.SalaryTa)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SalaryTA");

                entity.Property(e => e.Ssda)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SSDA");

                entity.Property(e => e.Ssta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SSTA");

                entity.Property(e => e.Ta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TA");

                entity.Property(e => e.TillDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CmsalaryStructureView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CMSalaryStructureView");

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bonus).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Da)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DA");

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.Grade)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GradeCategory)
                    .IsRequired()
                    .HasMaxLength(205)
                    .IsUnicode(false);

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.Hopi)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("HOPI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lopi)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LOPI");

                entity.Property(e => e.Ta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TA");

                entity.Property(e => e.TillDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CompanyInfo>(entity =>
            {
                entity.ToTable("CompanyInfo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerMaster>(entity =>
            {
                entity.ToTable("CustomerMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AccGroup)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccountHolderName)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankAccountNumber)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RoutingNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VendorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DailySecondarySalse>(entity =>
            {
                entity.ToTable("DailySecondarySalse");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid)
                    .HasColumnName("ABID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Abnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.CashDiscountTp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CashDiscountTP");

                entity.Property(e => e.DdsalesQty).HasColumnName("DDSalesQty");

                entity.Property(e => e.DdsalesValueLp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DDSalesValueLP");

                entity.Property(e => e.DdtotalLp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DDTotalLP");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsSendToTm).HasColumnName("IsSendToTM");

                entity.Property(e => e.SalesDate).HasColumnType("datetime");

                entity.Property(e => e.Skucode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SKUCode");

                entity.Property(e => e.Skuname)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SKUName");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tprcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TPRCode");
            });

            modelBuilder.Entity<DamageSalesValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DamageSalesValue");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimMasterId).HasColumnName("ClaimMasterID");

                entity.Property(e => e.Cumulative)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReasonDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RunningPercentage)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesValue).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Ddclaim>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DDClaim");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AmountInDocumentCurrency).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyKey)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentHeader)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Empty100)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty101)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty102)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty103)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty104)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty105)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty106)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty107)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty108)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty109)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty110)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty111)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty112)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty113)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty114)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty115)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty116)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty117)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty118)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty119)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty120)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty121)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty122)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty123)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty124)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty125)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty126)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty127)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty128)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty129)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty130)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty131)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty132)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty14)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty15)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty16)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty29)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty30)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty31)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty32)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty33)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty34)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Empty35)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty36)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty37)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty38)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty39)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty40)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty41)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty42)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty43)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty44)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty45)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty46)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty47)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty48)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty49)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty50)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty51)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty52)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty53)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty54)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty55)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty56)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty57)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty58)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty59)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty60)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty61)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty62)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty63)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty64)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty65)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty66)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty67)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty68)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty69)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty70)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty71)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty72)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty73)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty74)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty75)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty76)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty77)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty78)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty79)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty80)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty81)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty82)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty83)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty84)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty85)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty86)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty87)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty88)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty89)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty90)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty91)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty92)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty93)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty94)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty95)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty96)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty97)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty98)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Empty99)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmptyAa27)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EmptyAA27");

                entity.Property(e => e.EmptyAb28)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EmptyAB28");

                entity.Property(e => e.EmptyQ17)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmptyR18)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmptyS19)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmptyU21)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmptyV22)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmptyW23)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmptyX24)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmptyY25)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmptyZ26)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemText)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostingKey)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SeperatorForNewDocument)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DdclaimDetail>(entity =>
            {
                entity.ToTable("DDClaimDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Advance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CashDiscountTp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CashDiscountTP");

                entity.Property(e => e.DdlistValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DDListValue");

                entity.Property(e => e.DdsalesQty).HasColumnName("DDSalesQty");

                entity.Property(e => e.DdsalesValueLp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DDSalesValueLP");

                entity.Property(e => e.DdtotalLp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DDTotalLP");

                entity.Property(e => e.ListValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SalesDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Skucode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SKUCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Skuname)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SKUName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tprcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TPRCode")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.DdclaimDetails)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDClaimDetail_DDClaimMaster");
            });

            modelBuilder.Entity<DdclaimDetailView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DDClaimDetailView");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.Advance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CashDiscountTp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CashDiscountTP");

                entity.Property(e => e.DdlistValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DDListValue");

                entity.Property(e => e.DdsalesQty).HasColumnName("DDSalesQty");

                entity.Property(e => e.DdsalesValueLp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DDSalesValueLP");

                entity.Property(e => e.DdtotalLp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DDTotalLP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ListValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SalesDate).HasColumnType("datetime");

                entity.Property(e => e.Skucode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SKUCode");

                entity.Property(e => e.Skuname)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SKUName");

                entity.Property(e => e.Tprcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TPRCode");
            });

            modelBuilder.Entity<DdclaimMaster>(entity =>
            {
                entity.ToTable("DDClaimMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid)
                    .HasColumnName("ABID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Abnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdvanceAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BatchDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("For Perfect Store Damage");

                entity.Property(e => e.ClaimNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimSendId).HasColumnName("ClaimSendID");

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DdtotalAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DDTotalAmount");

                entity.Property(e => e.DifferanceAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsJvcreateCompany).HasColumnName("IsJVCreateCompany");

                entity.Property(e => e.IsJvcreateDistributor).HasColumnName("IsJVCreateDistributor");

                entity.Property(e => e.IsJvcreateFinal).HasColumnName("IsJVCreateFinal");

                entity.Property(e => e.IsJvcreateGsv).HasColumnName("IsJVCreateGSV");

                entity.Property(e => e.JvcreateDateCompany)
                    .HasColumnType("datetime")
                    .HasColumnName("JVCreateDateCompany");

                entity.Property(e => e.JvcreateDateDistributor)
                    .HasColumnType("datetime")
                    .HasColumnName("JVCreateDateDistributor");

                entity.Property(e => e.JvcreateDateFinal)
                    .HasColumnType("datetime")
                    .HasColumnName("JVCreateDateFinal");

                entity.Property(e => e.JvcreateDateGsv)
                    .HasColumnType("datetime")
                    .HasColumnName("JVCreateDateGSV");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.Property(e => e.WorkflowUserId).HasColumnName("WorkflowUserID");

                entity.HasOne(d => d.ClaimType)
                    .WithMany(p => p.DdclaimMasters)
                    .HasForeignKey(d => d.ClaimTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDClaimMaster_ValueList");
            });

            modelBuilder.Entity<DdclaimMasterView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DDClaimMasterView");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.AdvanceAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AdvanceAmountMillionFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimCategoryId).HasColumnName("ClaimCategoryID");

                entity.Property(e => e.ClaimDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimSendId).HasColumnName("ClaimSendID");

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DdtotalAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DDTotalAmount");

                entity.Property(e => e.DifferanceAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.ErrorMessage).HasColumnType("text");

                entity.Property(e => e.ForOrderBy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsJvcreateCompany).HasColumnName("IsJVCreateCompany");

                entity.Property(e => e.IsJvcreateDistributor).HasColumnName("IsJVCreateDistributor");

                entity.Property(e => e.IsJvcreateFinal).HasColumnName("IsJVCreateFinal");

                entity.Property(e => e.IsJvcreateGsv).HasColumnName("IsJVCreateGSV");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDetail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TownName1)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.Property(e => e.WorkflowUserId).HasColumnName("WorkflowUserID");
            });

            modelBuilder.Entity<DdclaimSendAsm>(entity =>
            {
                entity.ToTable("DDClaimSendASM");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Asm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ASM");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.Tm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TM");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.DdclaimSendAsms)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDClaimSendASM_DDClaimMaster");
            });

            modelBuilder.Entity<DdclaimSource>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DDClaimSource");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.ClaimNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EmptyAbnumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EmptyABNumber");

                entity.Property(e => e.PostingKey)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TotalClaimAmount).HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<DepartmentView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DepartmentView");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<DigradeGroupView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DIGradeGroupView");

                entity.Property(e => e.Grade)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GradeGroupId).HasColumnName("GradeGroupID");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.Group)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");
            });

            modelBuilder.Entity<Eccproduct>(entity =>
            {
                entity.ToTable("ECCProduct");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ph10claimPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10ClaimPrice");

                entity.Property(e => e.Ph10code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Code");

                entity.Property(e => e.Ph10ddccost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10DDCCost");

                entity.Property(e => e.Ph10dmscode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PH10DMSCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph10isActive)
                    .IsRequired()
                    .HasColumnName("PH10IsActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ph10listPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10ListPrice");

                entity.Property(e => e.Ph10name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Name");

                entity.Property(e => e.Ph10packSize).HasColumnName("PH10PackSize");

                entity.Property(e => e.Ph10pcsPerMt).HasColumnName("PH10PcsPerMT");

                entity.Property(e => e.Ph10retailPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10RetailPrice");

                entity.Property(e => e.Ph10saplistPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10SAPListPrice");

                entity.Property(e => e.Ph10shortName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10ShortName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph10tradePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10TradePrice");

                entity.Property(e => e.Ph10weight)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Weight")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph1code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1Code");

                entity.Property(e => e.Ph1name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1Name");

                entity.Property(e => e.Ph1profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1ProfitCenter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph2code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2Code");

                entity.Property(e => e.Ph2name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2Name");

                entity.Property(e => e.Ph2profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2ProfitCenter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph3code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3Code");

                entity.Property(e => e.Ph3name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3Name");

                entity.Property(e => e.Ph3profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3ProfitCenter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph3sapuser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3SAPUser")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph4code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4Code");

                entity.Property(e => e.Ph4name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4Name");

                entity.Property(e => e.Ph4profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4ProfitCenter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph5code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Code");

                entity.Property(e => e.Ph5name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Name");

                entity.Property(e => e.Ph6code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH6Code");

                entity.Property(e => e.Ph6name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH6Name");

                entity.Property(e => e.Ph7code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH7Code");

                entity.Property(e => e.Ph7name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH7Name");

                entity.Property(e => e.Ph8code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code");

                entity.Property(e => e.Ph8isActive)
                    .IsRequired()
                    .HasColumnName("PH8IsActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ph8name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Name");

                entity.Property(e => e.Ph9code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph9name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Name")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Eccproduct1>(entity =>
            {
                entity.ToTable("ECCProduct1");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ph10claimPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10ClaimPrice");

                entity.Property(e => e.Ph10code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Code");

                entity.Property(e => e.Ph10ddccost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10DDCCost");

                entity.Property(e => e.Ph10dmscode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PH10DMSCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph10isActive)
                    .IsRequired()
                    .HasColumnName("PH10IsActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ph10listPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10ListPrice");

                entity.Property(e => e.Ph10name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Name");

                entity.Property(e => e.Ph10packSize).HasColumnName("PH10PackSize");

                entity.Property(e => e.Ph10pcsPerMt).HasColumnName("PH10PcsPerMT");

                entity.Property(e => e.Ph10retailPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10RetailPrice");

                entity.Property(e => e.Ph10saplistPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10SAPListPrice");

                entity.Property(e => e.Ph10shortName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10ShortName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph10tradePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10TradePrice");

                entity.Property(e => e.Ph10weight)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Weight")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph1code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1Code");

                entity.Property(e => e.Ph1name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1Name");

                entity.Property(e => e.Ph1profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1ProfitCenter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph2code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2Code");

                entity.Property(e => e.Ph2name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2Name");

                entity.Property(e => e.Ph2profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2ProfitCenter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph3code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3Code");

                entity.Property(e => e.Ph3name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3Name");

                entity.Property(e => e.Ph3profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3ProfitCenter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph3sapuser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3SAPUser")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph4code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4Code");

                entity.Property(e => e.Ph4name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4Name");

                entity.Property(e => e.Ph4profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4ProfitCenter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph5code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Code");

                entity.Property(e => e.Ph5name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Name");

                entity.Property(e => e.Ph6code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH6Code");

                entity.Property(e => e.Ph6name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH6Name");

                entity.Property(e => e.Ph7code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH7Code");

                entity.Property(e => e.Ph7name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH7Name");

                entity.Property(e => e.Ph8code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code");

                entity.Property(e => e.Ph8isActive)
                    .IsRequired()
                    .HasColumnName("PH8IsActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ph8name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Name");

                entity.Property(e => e.Ph9code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph9name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Name")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<EccproductTemp>(entity =>
            {
                entity.ToTable("ECCProductTemp");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ph10claimPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10ClaimPrice");

                entity.Property(e => e.Ph10code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Code");

                entity.Property(e => e.Ph10ddccost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10DDCCost");

                entity.Property(e => e.Ph10dmscode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PH10DMSCode");

                entity.Property(e => e.Ph10isActive).HasColumnName("PH10IsActive");

                entity.Property(e => e.Ph10listPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10ListPrice");

                entity.Property(e => e.Ph10name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Name");

                entity.Property(e => e.Ph10packSize).HasColumnName("PH10PackSize");

                entity.Property(e => e.Ph10pcsPerMt).HasColumnName("PH10PcsPerMT");

                entity.Property(e => e.Ph10retailPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10RetailPrice");

                entity.Property(e => e.Ph10saplistPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10SAPListPrice");

                entity.Property(e => e.Ph10shortName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10ShortName");

                entity.Property(e => e.Ph10tradePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10TradePrice");

                entity.Property(e => e.Ph10weight)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Weight");

                entity.Property(e => e.Ph1code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1Code");

                entity.Property(e => e.Ph1name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1Name");

                entity.Property(e => e.Ph1profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1ProfitCenter");

                entity.Property(e => e.Ph2code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2Code");

                entity.Property(e => e.Ph2name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2Name");

                entity.Property(e => e.Ph2profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2ProfitCenter");

                entity.Property(e => e.Ph3code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3Code");

                entity.Property(e => e.Ph3name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3Name");

                entity.Property(e => e.Ph3profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3ProfitCenter");

                entity.Property(e => e.Ph3sapuser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3SAPUser");

                entity.Property(e => e.Ph4code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4Code");

                entity.Property(e => e.Ph4name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4Name");

                entity.Property(e => e.Ph4profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4ProfitCenter");

                entity.Property(e => e.Ph5code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Code");

                entity.Property(e => e.Ph5name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Name");

                entity.Property(e => e.Ph6code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH6Code");

                entity.Property(e => e.Ph6name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH6Name");

                entity.Property(e => e.Ph7code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH7Code");

                entity.Property(e => e.Ph7name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH7Name");

                entity.Property(e => e.Ph8code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code");

                entity.Property(e => e.Ph8isActive).HasColumnName("PH8IsActive");

                entity.Property(e => e.Ph8name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Name");

                entity.Property(e => e.Ph9code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code");

                entity.Property(e => e.Ph9name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Name");
            });

            modelBuilder.Entity<EccproductTemp2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ECCProductTemp2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ph10claimPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10ClaimPrice");

                entity.Property(e => e.Ph10code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Code");

                entity.Property(e => e.Ph10ddccost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10DDCCost");

                entity.Property(e => e.Ph10dmscode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PH10DMSCode");

                entity.Property(e => e.Ph10isActive).HasColumnName("PH10IsActive");

                entity.Property(e => e.Ph10listPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10ListPrice");

                entity.Property(e => e.Ph10name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Name");

                entity.Property(e => e.Ph10packSize).HasColumnName("PH10PackSize");

                entity.Property(e => e.Ph10pcsPerMt).HasColumnName("PH10PcsPerMT");

                entity.Property(e => e.Ph10retailPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10RetailPrice");

                entity.Property(e => e.Ph10saplistPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10SAPListPrice");

                entity.Property(e => e.Ph10shortName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10ShortName");

                entity.Property(e => e.Ph10tradePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10TradePrice");

                entity.Property(e => e.Ph10weight)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Weight");

                entity.Property(e => e.Ph1code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1Code");

                entity.Property(e => e.Ph1name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1Name");

                entity.Property(e => e.Ph1profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1ProfitCenter");

                entity.Property(e => e.Ph2code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2Code");

                entity.Property(e => e.Ph2name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2Name");

                entity.Property(e => e.Ph2profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2ProfitCenter");

                entity.Property(e => e.Ph3code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3Code");

                entity.Property(e => e.Ph3name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3Name");

                entity.Property(e => e.Ph3profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3ProfitCenter");

                entity.Property(e => e.Ph3sapuser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3SAPUser");

                entity.Property(e => e.Ph4code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4Code");

                entity.Property(e => e.Ph4name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4Name");

                entity.Property(e => e.Ph4profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4ProfitCenter");

                entity.Property(e => e.Ph5code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Code");

                entity.Property(e => e.Ph5name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Name");

                entity.Property(e => e.Ph6code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH6Code");

                entity.Property(e => e.Ph6name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH6Name");

                entity.Property(e => e.Ph7code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH7Code");

                entity.Property(e => e.Ph7name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH7Name");

                entity.Property(e => e.Ph8code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code");

                entity.Property(e => e.Ph8isActive).HasColumnName("PH8IsActive");

                entity.Property(e => e.Ph8name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Name");

                entity.Property(e => e.Ph9code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code");

                entity.Property(e => e.Ph9name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Name");
            });

            modelBuilder.Entity<Expenditure>(entity =>
            {
                entity.ToTable("Expenditure");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abmodules)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ABModules");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Eh1code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EH1Code");

                entity.Property(e => e.Eh1name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EH1Name");

                entity.Property(e => e.Eh2code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EH2Code");

                entity.Property(e => e.Eh2name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EH2Name");

                entity.Property(e => e.Eh3code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EH3Code");

                entity.Property(e => e.Eh3name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EH3Name");

                entity.Property(e => e.Eh4code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EH4Code");

                entity.Property(e => e.Eh4name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EH4Name");
            });

            modelBuilder.Entity<FileAttachment>(entity =>
            {
                entity.ToTable("FileAttachment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FileProcessLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FileProcessLog");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FileTransferLogDmstoUpropose>(entity =>
            {
                entity.ToTable("FileTransferLogDMStoUPropose");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(100);
            });

            modelBuilder.Entity<FinancialImpactView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FinancialImpactView");

                entity.Property(e => e.ActualGm)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("ActualGM");

                entity.Property(e => e.ActualRsp)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("ActualRSP");

                entity.Property(e => e.ActualTm)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("ActualTM");

                entity.Property(e => e.CompetitorRsp)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("CompetitorRSP");

                entity.Property(e => e.CompetitorTm)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("CompetitorTM");

                entity.Property(e => e.ForecastGm)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("ForecastGM");

                entity.Property(e => e.ForecastRsp)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("ForecastRSP");

                entity.Property(e => e.ForecastTm)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("ForecastTM");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Skus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SKUs");
            });

            modelBuilder.Entity<ForecastOpsbrand>(entity =>
            {
                entity.ToTable("ForecastOPSBrand");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AbsoluteRatio).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AllocationAbsolute).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AllocationGsv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AllocationGSV");

                entity.Property(e => e.Gsv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSV");

                entity.Property(e => e.Gsvratio)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("GSVRatio");

                entity.Property(e => e.Opsid).HasColumnName("OPSID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Ph5code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph5name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph8code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph8name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph9code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph9name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Name")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ForecastOpsbrands)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ForecastOPSBrand_ForecatOPSDetail");
            });

            modelBuilder.Entity<ForecastOpsdetail>(entity =>
            {
                entity.ToTable("ForecastOPSDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ABAmount");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ActivityName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.ActualAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.April).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.August).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BudgetSubHead)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.December).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.February).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.January).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.July).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.June).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.March).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.May).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.November).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.October).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Opsamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OPSAmount");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SelectedRatio).HasDefaultValueSql("((1))");

                entity.Property(e => e.September).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ytdamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("YTDAmount");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ForecastOpsdetails)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ForecatOPSDetail_ForecastOPSMaster");
            });

            modelBuilder.Entity<ForecastOpsmaster>(entity =>
            {
                entity.ToTable("ForecastOPSMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.ScenarioId).HasColumnName("ScenarioID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<ForecastProcessedDataView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ForecastProcessedDataView");

                entity.Property(e => e.AprilYtd).HasColumnName("AprilYTD");

                entity.Property(e => e.AugustYtd).HasColumnName("AugustYTD");

                entity.Property(e => e.DecemberYtd).HasColumnName("DecemberYTD");

                entity.Property(e => e.FebruaryYtd).HasColumnName("FebruaryYTD");

                entity.Property(e => e.FirstHalfYtd).HasColumnName("FirstHalfYTD");

                entity.Property(e => e.JanuaryYtd).HasColumnName("JanuaryYTD");

                entity.Property(e => e.JulyYtd).HasColumnName("JulyYTD");

                entity.Property(e => e.JuneYtd).HasColumnName("JuneYTD");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.MarchYtd).HasColumnName("MarchYTD");

                entity.Property(e => e.MayYtd).HasColumnName("MayYTD");

                entity.Property(e => e.MeasureCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeasureDescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MeasureId).HasColumnName("MeasureID");

                entity.Property(e => e.NovemberYtd).HasColumnName("NovemberYTD");

                entity.Property(e => e.OctoberYtd).HasColumnName("OctoberYTD");

                entity.Property(e => e.Ph0code)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PH0Code");

                entity.Property(e => e.Ph0name)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("PH0Name");

                entity.Property(e => e.Ph1code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1Code");

                entity.Property(e => e.Ph1name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1Name");

                entity.Property(e => e.Ph2code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2Code");

                entity.Property(e => e.Ph2name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2Name");

                entity.Property(e => e.Ph3code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3Code");

                entity.Property(e => e.Ph3name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3Name");

                entity.Property(e => e.Ph4code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4Code");

                entity.Property(e => e.Ph4name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4Name");

                entity.Property(e => e.Ph5code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Code");

                entity.Property(e => e.Ph5name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Name");

                entity.Property(e => e.Ph6code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH6Code");

                entity.Property(e => e.Ph6name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH6Name");

                entity.Property(e => e.Ph7code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH7Code");

                entity.Property(e => e.Ph7name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH7Name");

                entity.Property(e => e.Ph8code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code");

                entity.Property(e => e.Ph8name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Name");

                entity.Property(e => e.Ph9code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code");

                entity.Property(e => e.Ph9name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Name");

                entity.Property(e => e.Q1total).HasColumnName("Q1Total");

                entity.Property(e => e.Q1totalYtd).HasColumnName("Q1TotalYTD");

                entity.Property(e => e.Q2total).HasColumnName("Q2Total");

                entity.Property(e => e.Q2totalYtd).HasColumnName("Q2TotalYTD");

                entity.Property(e => e.Q3total).HasColumnName("Q3Total");

                entity.Property(e => e.Q3totalYtd).HasColumnName("Q3TotalYTD");

                entity.Property(e => e.Q4total).HasColumnName("Q4Total");

                entity.Property(e => e.Q4totalYtd).HasColumnName("Q4TotalYTD");

                entity.Property(e => e.ScenarioId).HasColumnName("ScenarioID");

                entity.Property(e => e.SecondHalfYtd).HasColumnName("SecondHalfYTD");

                entity.Property(e => e.SeptemberYtd).HasColumnName("SeptemberYTD");

                entity.Property(e => e.YearlyTotalYtd).HasColumnName("YearlyTotalYTD");
            });

            modelBuilder.Entity<ForecastProcessedDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MeasureCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MeasureDescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MeasureId).HasColumnName("MeasureID");

                entity.Property(e => e.Ph9code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ScenarioId).HasColumnName("ScenarioID");
            });

            modelBuilder.Entity<HistoryAbauthoUser>(entity =>
            {
                entity.ToTable("HistoryABAuthoUser");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AmendNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProcessTime).HasColumnType("datetime");

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.HistoryAbauthoUsers)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoryABAuthoUser_HistoryABMaster");
            });

            modelBuilder.Entity<HistoryAbdetail>(entity =>
            {
                entity.ToTable("HistoryABDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.AgencyTypeId).HasColumnName("AgencyTypeID");

                entity.Property(e => e.AiringDate).HasColumnType("datetime");

                entity.Property(e => e.Background)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CategoryCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpTypeId).HasColumnName("ExpTypeID");

                entity.Property(e => e.FifthLvlResearchTypeId).HasColumnName("FifthLvlResearchTypeID");

                entity.Property(e => e.FirstLvlResearchTypeId).HasColumnName("FirstLvlResearchTypeID");

                entity.Property(e => e.FirstSendDate).HasColumnType("date");

                entity.Property(e => e.ForecastScenarioId).HasColumnName("ForecastScenarioID");

                entity.Property(e => e.ForthLvlResearchTypeId).HasColumnName("ForthLvlResearchTypeID");

                entity.Property(e => e.FrequencyComments)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FrequencyValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Grpcomments)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GRPComments")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Grpvalue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GRPValue");

                entity.Property(e => e.InfoProbScope)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JobDescription)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MeasureCriteria)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Methodology)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Objective)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Omquarter).HasColumnName("OMQuarter");

                entity.Property(e => e.OpsPlanId).HasColumnName("OpsPlanID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ReachComments)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReachValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RecomUserId).HasColumnName("RecomUserID");

                entity.Property(e => e.Rotcriteria)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("ROTCriteria")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rotrewards)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("ROTRewards")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SampleRevDate).HasColumnType("datetime");

                entity.Property(e => e.SecondLvlResearchTypeId).HasColumnName("SecondLvlResearchTypeID");

                entity.Property(e => e.StimulationRevDate).HasColumnType("datetime");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.TgtAudienceId).HasColumnName("TgtAudienceID");

                entity.Property(e => e.ThirdtLvlResearchTypeId).HasColumnName("ThirdtLvlResearchTypeID");

                entity.Property(e => e.TradeType).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.HistoryAbdetails)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoryABDetail_HistoryABMaster");
            });

            modelBuilder.Entity<HistoryAbmaster>(entity =>
            {
                entity.ToTable("HistoryABMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ABAmount");

                entity.Property(e => e.Abdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ABDate");

                entity.Property(e => e.Abdetails)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ABDetails")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.AbslNo).HasColumnName("ABSlNo");

                entity.Property(e => e.Abtype).HasColumnName("ABType");

                entity.Property(e => e.ActivityEndDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityStartDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.ChargeAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimTypeId).HasColumnName("ClaimTypeID");

                entity.Property(e => e.ClosureDate).HasColumnType("datetime");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.InvoiceDiscountType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1-off invoice,2- on invoice");

                entity.Property(e => e.IsBudgeted)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsFdconsult).HasColumnName("IsFDConsult");

                entity.Property(e => e.Npiamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NPIAmount");

                entity.Property(e => e.PaymentAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProfitCenter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProvisionAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SystemType).HasComment("0-None,1-Ariba,2-Non-Ariba");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.HasOne(d => d.Ab)
                    .WithMany(p => p.HistoryAbmasters)
                    .HasForeignKey(d => d.Abid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoryABMaster_ABMaster");
            });

            modelBuilder.Entity<HistoryAbproduct>(entity =>
            {
                entity.ToTable("HistoryABProduct");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abratio)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ABRatio");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpTypeId).HasColumnName("ExpTypeID");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MasterItem)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Npsratio)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NPSRatio");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Ph10code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph8code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph9code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PromoActualValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromoInputValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Roicalculation)
                    .IsRequired()
                    .HasColumnName("ROICalculation")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TargetVolume).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.HistoryAbproducts)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoryABProduct_HistoryABMaster");
            });

            modelBuilder.Entity<HistoryAbproductChannel>(entity =>
            {
                entity.ToTable("HistoryABProductChannel");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.ChannelId).HasColumnName("ChannelID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<HistoryOpsbrand>(entity =>
            {
                entity.ToTable("HistoryOPSBrand");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AbsoluteRatio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AllocationAbsolute).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AllocationGsv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AllocationGSV");

                entity.Property(e => e.Gsv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSV");

                entity.Property(e => e.Gsvratio)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSVRatio");

                entity.Property(e => e.Opsid).HasColumnName("OPSID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Ph5code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Code");

                entity.Property(e => e.Ph5name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Name");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.HistoryOpsbrands)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoryOPSBrand_HistoryOPSDetail");
            });

            modelBuilder.Entity<HistoryOpsdetail>(entity =>
            {
                entity.ToTable("HistoryOPSDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.ActivityName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.April).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.August).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BudgetSubHead)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.December).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.February).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.January).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.July).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.June).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.March).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.May).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.November).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.October).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ScenarioId).HasColumnName("ScenarioID");

                entity.Property(e => e.September).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<HolidaySetup>(entity =>
            {
                entity.ToTable("HolidaySetup");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Holiday).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<Jccalendar>(entity =>
            {
                entity.ToTable("JCCalendar");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Jccode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("JCCode");

                entity.Property(e => e.Jcyear).HasColumnName("JCYear");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<JccalendarView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("JCCalendarView");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EndDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndMonthYearText).HasMaxLength(35);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Jccode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("JCCode");

                entity.Property(e => e.JcendDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("JCEndDate");

                entity.Property(e => e.JcstartDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("JCStartDate");

                entity.Property(e => e.Jctext)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("JCText");

                entity.Property(e => e.Jcyear).HasColumnName("JCYear");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StartDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartMonthYearText).HasMaxLength(35);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<KeyAccount>(entity =>
            {
                entity.ToTable("KeyAccount");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<LateClaimUploadCategorySetUp>(entity =>
            {
                entity.ToTable("LateClaimUploadCategorySetUp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllowedDate).HasColumnType("datetime");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            });

            modelBuilder.Entity<LateClaimUploadDistributorSetUp>(entity =>
            {
                entity.ToTable("LateClaimUploadDistributorSetUp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllowedDate).HasColumnType("datetime");

                entity.Property(e => e.AllowedToDate).HasColumnType("datetime");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExceptionApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Town)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LateClaimUploadDistributorSetUpView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LateClaimUploadDistributorSetUp_View");

                entity.Property(e => e.AllowedDate).HasColumnType("datetime");

                entity.Property(e => e.AllowedToDate).HasColumnType("datetime");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExceptionApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Town)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LateClaimUploadSetUp>(entity =>
            {
                entity.ToTable("LateClaimUploadSetUp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllowedDate).HasColumnType("datetime");

                entity.Property(e => e.AllowedToDate).HasColumnType("datetime");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.DistributorCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExceptionApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Town)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListOfOnMillionAbview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ListOfOnMillionABView");

                entity.Property(e => e.Abamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ABAmount");

                entity.Property(e => e.Abdescription)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ABDescription");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.ActivityEndDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityStartDate).HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EndDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Fdconsult)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FDConsult");

                entity.Property(e => e.Initiator)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.IsFdconsult).HasColumnName("IsFDConsult");

                entity.Property(e => e.Send)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StartDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LocationEmployee>(entity =>
            {
                entity.ToTable("LocationEmployee");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Employee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationTypeId).HasColumnName("LocationTypeID");

                entity.Property(e => e.ParentLocation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<LocationEmployee2>(entity =>
            {
                entity.ToTable("LocationEmployee2");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Employee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Employee1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationTypeId).HasColumnName("LocationTypeID");

                entity.Property(e => e.ParentLocation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.HasOne(d => d.LocationType)
                    .WithMany(p => p.LocationEmployee2s)
                    .HasForeignKey(d => d.LocationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocationEmployee_ValueList");
            });

            modelBuilder.Entity<LocationEmployeeNew>(entity =>
            {
                entity.ToTable("LocationEmployeeNew");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Employee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationTypeId).HasColumnName("LocationTypeID");

                entity.Property(e => e.ParentLocation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<LocationEmployeeVertically>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LocationEmployeeVertically");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AreaCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaLocationTypeId).HasColumnName("AreaLocationTypeID");

                entity.Property(e => e.Asm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASM");

                entity.Property(e => e.Distributor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorEmail)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorId).HasColumnName("DistributorID");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.RegionLocationTypeId).HasColumnName("RegionLocationTypeID");

                entity.Property(e => e.Rsm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RSM");

                entity.Property(e => e.Sapcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAPCode");

                entity.Property(e => e.Territory)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TerritoryCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.Property(e => e.TerritoryLocationTypeId).HasColumnName("TerritoryLocationTypeID");

                entity.Property(e => e.Tm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TM");
            });

            modelBuilder.Entity<LocationEmployeeView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LocationEmployeeView");

                entity.Property(e => e.Employee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationTypeId).HasColumnName("LocationTypeID");

                entity.Property(e => e.ParentLocation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<LocationUserVertically>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LocationUserVertically");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AreaCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaLocationTypeId).HasColumnName("AreaLocationTypeID");

                entity.Property(e => e.Asmcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASMCode");

                entity.Property(e => e.Asmemail)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ASMEmail");

                entity.Property(e => e.Asmid).HasColumnName("ASMID");

                entity.Property(e => e.Asmname)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false)
                    .HasColumnName("ASMName");

                entity.Property(e => e.Distributor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorEmail)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorId).HasColumnName("DistributorID");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.RegionLocationTypeId).HasColumnName("RegionLocationTypeID");

                entity.Property(e => e.Rsmcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RSMCode");

                entity.Property(e => e.Rsmemail)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RSMEmail");

                entity.Property(e => e.Rsmid).HasColumnName("RSMID");

                entity.Property(e => e.Rsmname)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false)
                    .HasColumnName("RSMName");

                entity.Property(e => e.Sapcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAPCode");

                entity.Property(e => e.Territory)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TerritoryCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.Property(e => e.TerritoryLocationTypeId).HasColumnName("TerritoryLocationTypeID");

                entity.Property(e => e.Tmcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TMCode");

                entity.Property(e => e.Tmemail)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TMEmail");

                entity.Property(e => e.Tmid).HasColumnName("TMID");

                entity.Property(e => e.Tmname)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false)
                    .HasColumnName("TMName");
            });

            modelBuilder.Entity<LocationVertically>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LocationVertically");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AreaCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Distributor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorEmail)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorId).HasColumnName("DistributorID");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegionCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Sapcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAPCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Territory)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TerritoryCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<LocationVerticallyForUnibd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LocationVerticallyForUNIBD");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AreaCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaLocationTypeId).HasColumnName("AreaLocationTypeID");

                entity.Property(e => e.Asmcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASMCode");

                entity.Property(e => e.Asmemail)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ASMEmail");

                entity.Property(e => e.Asmid).HasColumnName("ASMID");

                entity.Property(e => e.Asmname)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false)
                    .HasColumnName("ASMName");

                entity.Property(e => e.Distributor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorEmail)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorId).HasColumnName("DistributorID");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.RegionLocationTypeId).HasColumnName("RegionLocationTypeID");

                entity.Property(e => e.Rsmcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RSMCode");

                entity.Property(e => e.Rsmemail)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RSMEmail");

                entity.Property(e => e.Rsmid).HasColumnName("RSMID");

                entity.Property(e => e.Rsmname)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false)
                    .HasColumnName("RSMName");

                entity.Property(e => e.Sapcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAPCode");

                entity.Property(e => e.Territory)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TerritoryCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.Property(e => e.TerritoryLocationTypeId).HasColumnName("TerritoryLocationTypeID");

                entity.Property(e => e.Tmcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TMCode");

                entity.Property(e => e.Tmemail)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TMEmail");

                entity.Property(e => e.Tmid).HasColumnName("TMID");

                entity.Property(e => e.Tmname)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false)
                    .HasColumnName("TMName");
            });

            modelBuilder.Entity<LocationVerticallyNotInUse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LocationVerticallyNotInUse");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AreaCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Distributor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorEmail)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorId).HasColumnName("DistributorID");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Sapcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAPCode");

                entity.Property(e => e.Territory)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TerritoryCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<LockedScenario>(entity =>
            {
                entity.ToTable("LockedScenario");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.ScenarioId).HasColumnName("ScenarioID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<ManualClaimPendingAmount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ManualClaimPendingAmount");

                entity.Property(e => e.DistributorCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PendingAmountFormatted)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDateFormatted)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MatrixProcessDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MatrixProcessData");

                entity.Property(e => e.MeasureId).HasColumnName("MeasureID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.ProcessDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ScenarioId).HasColumnName("ScenarioID");

                entity.Property(e => e.Skuid).HasColumnName("SKUID");
            });

            modelBuilder.Entity<MatrixProduct>(entity =>
            {
                entity.ToTable("MatrixProduct");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ph10claimPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10ClaimPrice");

                entity.Property(e => e.Ph10code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Code");

                entity.Property(e => e.Ph10ddccost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10DDCCost");

                entity.Property(e => e.Ph10dmscode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PH10DMSCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph10isActive)
                    .IsRequired()
                    .HasColumnName("PH10IsActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ph10listPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10ListPrice");

                entity.Property(e => e.Ph10name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH10Name");

                entity.Property(e => e.Ph10packSize).HasColumnName("PH10PackSize");

                entity.Property(e => e.Ph10pcsPerMt).HasColumnName("PH10PcsPerMT");

                entity.Property(e => e.Ph10retailPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10RetailPrice");

                entity.Property(e => e.Ph10saplistPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10SAPListPrice");

                entity.Property(e => e.Ph10shortName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10ShortName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph10tradePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10TradePrice");

                entity.Property(e => e.Ph10weight)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Weight")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph1code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1Code");

                entity.Property(e => e.Ph1name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH1Name");

                entity.Property(e => e.Ph1profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1ProfitCenter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph2code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2Code");

                entity.Property(e => e.Ph2name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH2Name");

                entity.Property(e => e.Ph2profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2ProfitCenter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph3code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3Code");

                entity.Property(e => e.Ph3name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH3Name");

                entity.Property(e => e.Ph3profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3ProfitCenter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph3sapuser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3SAPUser")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph4code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4Code");

                entity.Property(e => e.Ph4name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH4Name");

                entity.Property(e => e.Ph4profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4ProfitCenter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph5code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Code");

                entity.Property(e => e.Ph5name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH5Name");

                entity.Property(e => e.Ph6code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH6Code");

                entity.Property(e => e.Ph6name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH6Name");

                entity.Property(e => e.Ph7code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH7Code");

                entity.Property(e => e.Ph7name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH7Name");

                entity.Property(e => e.Ph8code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code");

                entity.Property(e => e.Ph8isActive)
                    .IsRequired()
                    .HasColumnName("PH8IsActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ph8name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH8Name");

                entity.Property(e => e.Ph9code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph9name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH9Name")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MatrixProduct2020>(entity =>
            {
                entity.ToTable("MatrixProduct2020");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ph10claimPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10ClaimPrice");

                entity.Property(e => e.Ph10code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Code");

                entity.Property(e => e.Ph10ddccost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10DDCCost");

                entity.Property(e => e.Ph10dmscode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PH10DMSCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph10isActive)
                    .IsRequired()
                    .HasColumnName("PH10IsActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ph10listPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10ListPrice");

                entity.Property(e => e.Ph10name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH10Name");

                entity.Property(e => e.Ph10packSize).HasColumnName("PH10PackSize");

                entity.Property(e => e.Ph10pcsPerMt).HasColumnName("PH10PcsPerMT");

                entity.Property(e => e.Ph10retailPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10RetailPrice");

                entity.Property(e => e.Ph10saplistPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10SAPListPrice");

                entity.Property(e => e.Ph10shortName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10ShortName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph10tradePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PH10TradePrice");

                entity.Property(e => e.Ph10weight)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Weight")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph1code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1Code");

                entity.Property(e => e.Ph1name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH1Name");

                entity.Property(e => e.Ph1profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH1ProfitCenter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph2code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2Code");

                entity.Property(e => e.Ph2name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH2Name");

                entity.Property(e => e.Ph2profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH2ProfitCenter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph3code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3Code");

                entity.Property(e => e.Ph3name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH3Name");

                entity.Property(e => e.Ph3profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3ProfitCenter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph3sapuser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH3SAPUser")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph4code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4Code");

                entity.Property(e => e.Ph4name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH4Name");

                entity.Property(e => e.Ph4profitCenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH4ProfitCenter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph5code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Code");

                entity.Property(e => e.Ph5name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH5Name");

                entity.Property(e => e.Ph6code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH6Code");

                entity.Property(e => e.Ph6name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH6Name");

                entity.Property(e => e.Ph7code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH7Code");

                entity.Property(e => e.Ph7name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH7Name");

                entity.Property(e => e.Ph8code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code");

                entity.Property(e => e.Ph8isActive)
                    .IsRequired()
                    .HasColumnName("PH8IsActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ph8name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH8Name");

                entity.Property(e => e.Ph9code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph9name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH9Name")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<MobileAttachment>(entity =>
            {
                entity.ToTable("MobileAttachment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.ToTable("Module");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AgreeLogInIds)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AgreeLogInIDs")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AgreeUserIds)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AgreeUserIDs")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ApprovalLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedDays).HasDefaultValueSql("((10))");

                entity.Property(e => e.CanAuthoOwnAb).HasColumnName("CanAuthoOwnAB");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CostElement)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EvaluationLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GreaterAgreeUserId).HasColumnName("GreaterAgreeUserID");

                entity.Property(e => e.GreaterAuthoriseUserId).HasColumnName("GreaterAuthoriseUserID");

                entity.Property(e => e.GreaterUserId).HasColumnName("GreaterUserID");

                entity.Property(e => e.Iotype)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IOType")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LessAuthoriseUserId).HasColumnName("LessAuthoriseUserID");

                entity.Property(e => e.LessUserId).HasColumnName("LessUserID");

                entity.Property(e => e.MbreviewUserId).HasColumnName("MBReviewUserID");

                entity.Property(e => e.ProcessingGroup)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sapuser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAPUser")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UnbudgetAuthoUserId1).HasColumnName("UnbudgetAuthoUserID1");

                entity.Property(e => e.UnbudgetAuthoUserId2).HasColumnName("UnbudgetAuthoUserID2");
            });

            modelBuilder.Entity<ModuleGl>(entity =>
            {
                entity.ToTable("ModuleGL");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AbtypeId).HasColumnName("ABTypeID");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.ChargeCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionalArea)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaymentCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaymentDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProvisionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProvisionDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Abtype)
                    .WithMany(p => p.ModuleGls)
                    .HasForeignKey(d => d.AbtypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModuleGL_Module");

                entity.HasOne(d => d.ActivityType)
                    .WithMany(p => p.ModuleGls)
                    .HasForeignKey(d => d.ActivityTypeId)
                    .HasConstraintName("FK_ModuleGL_ValueList");
            });

            modelBuilder.Entity<MonthlyClaimManual>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MonthlyClaimManual");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimGroup)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimReference)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimSpecificName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DeductedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorClaimReference)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RejectDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SettledAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SettledDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MonthlySalesTrendVolumeView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MonthlySalesTrendVolumeView");

                entity.Property(e => e.April).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.August).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.December).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.February).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.January).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.July).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.June).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.March).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.May).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.November).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.October).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Ph9name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Name");

                entity.Property(e => e.September).HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<Npsratio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NPSRatio");

                entity.Property(e => e.April).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.August).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.December).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.February).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.January).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.July).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.June).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.March).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.May).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.November).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Npstype).HasColumnName("NPSType");

                entity.Property(e => e.Npsyear).HasColumnName("NPSYear");

                entity.Property(e => e.October).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ph10code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Code");

                entity.Property(e => e.Ph8code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code");

                entity.Property(e => e.Ph9code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code");

                entity.Property(e => e.Ratio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.September).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Npsratio12>(entity =>
            {
                entity.ToTable("NPSRatio12");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.April).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.August).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.December).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.February).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.January).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.July).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.June).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.March).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.May).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.November).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Npstype).HasColumnName("NPSType");

                entity.Property(e => e.Npsyear).HasColumnName("NPSYear");

                entity.Property(e => e.October).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ph10code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Code");

                entity.Property(e => e.Ph8code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code");

                entity.Property(e => e.Ph9code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code");

                entity.Property(e => e.Ratio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.September).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<NpsratioBmilocal>(entity =>
            {
                entity.ToTable("NPSRatioBMILocal");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.April).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.August).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.December).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.February).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.January).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.July).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.June).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.March).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.May).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.November).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Npstype).HasColumnName("NPSType");

                entity.Property(e => e.Npsyear).HasColumnName("NPSYear");

                entity.Property(e => e.October).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ph10code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH10Code");

                entity.Property(e => e.Ph8code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code");

                entity.Property(e => e.Ph9code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code");

                entity.Property(e => e.Ratio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.September).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Opsbrand>(entity =>
            {
                entity.ToTable("OPSBrand");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AbsoluteRatio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AllocationAbsolute).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AllocationGsv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AllocationGSV");

                entity.Property(e => e.Gsv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSV");

                entity.Property(e => e.Gsvratio)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSVRatio");

                entity.Property(e => e.Opsid).HasColumnName("OPSID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Ph5code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ph5name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH5Name")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Opsbrands)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OPSBrand_OPSDetail");
            });

            modelBuilder.Entity<Opsdetail>(entity =>
            {
                entity.ToTable("OPSDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.ActivityName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.April).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.August).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BudgetSubHead)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.December).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.February).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.January).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.July).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.June).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.March).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.May).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.November).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.October).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ScenarioId).HasColumnName("ScenarioID");

                entity.Property(e => e.SelectedRatio).HasDefaultValueSql("((1))");

                entity.Property(e => e.September).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Opsmaster>(entity =>
            {
                entity.ToTable("OPSMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.Opsyear).HasColumnName("OPSYear");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<Pending>(entity =>
            {
                entity.ToTable("Pending");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abamount)
                    .HasColumnType("money")
                    .HasColumnName("ABAmount");

                entity.Property(e => e.Abdescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ABDescription")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Abtype).HasColumnName("ABType");

                entity.Property(e => e.ApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Ab)
                    .WithMany(p => p.Pendings)
                    .HasForeignKey(d => d.Abid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pending_ABMaster");
            });

            modelBuilder.Entity<PendingBill>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PendingBill");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillDetail)
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");
            });

            modelBuilder.Entity<PendingClaimAmount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PendingClaimAmount");

                entity.Property(e => e.ClosedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PendingAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PendingClaimAmount1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PendingClaimAmount1");

                entity.Property(e => e.ClosedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PendingAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PhupdateDumpDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PHUpdateDumpData");

                entity.Property(e => e.NewCode)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OldCode)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PoavailibilityComplain>(entity =>
            {
                entity.ToTable("POAvailibilityComplain");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActionerComments)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AssignedEmployee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AssignedEmployeeEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AssignedEmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AssignedEmployeePhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Attachment)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserEmployee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryUserEmployeeEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryUserEmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryUserEmployeePhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LandMark)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MarketId).HasColumnName("MarketID");

                entity.Property(e => e.MarketName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MatterDate).HasColumnType("datetime");

                entity.Property(e => e.Products)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('nn')");

                entity.Property(e => e.ReOpenDate).HasColumnType("datetime");

                entity.Property(e => e.RequesterComments)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StoreKeeperName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StoreKeeperPhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserEmployee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateUserEmployeeEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateUserEmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateUserEmployeePhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<Podmaster>(entity =>
            {
                entity.ToTable("PODMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActualReceiveDate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActualReceiveTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdocCreationSystemDate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdocSystemDate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InterfaceProgram)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaterialCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTransaction)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PoemployeeGroup>(entity =>
            {
                entity.ToTable("POEmployeeGroup");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Employee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GroupTypeId).HasColumnName("GroupTypeID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<PoemployeeRole>(entity =>
            {
                entity.ToTable("POEmployeeRole");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Employee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<Pomarket>(entity =>
            {
                entity.ToTable("POMarket");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Distributor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<PomustSku>(entity =>
            {
                entity.ToTable("POMustSKU");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.GrocerType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GrocerTypeId).HasColumnName("GrocerTypeID");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SKU")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PoproductComplain>(entity =>
            {
                entity.ToTable("POProductComplain");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BatchCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ComplainNatureId).HasColumnName("ComplainNatureID");

                entity.Property(e => e.ComplainTypeId).HasColumnName("ComplainTypeID");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Details)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Employee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FinalComments)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GeographicLocation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ManufacturingUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OfficeLocation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PackingCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Picture1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Picture2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Picture3)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Picture4)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PriorityTypeId).HasColumnName("PriorityTypeID");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductionActionTaken)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductionComments)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductionDesignation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductionEmployee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductionInvestigation)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductionUserId)
                    .HasColumnName("ProductionUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QaactionAgree)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("QAActionAgree")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QaactionTaken)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("QAActionTaken")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QaagreeComments)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("QAAgreeComments")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QaagreeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("QAAgreeDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.QaagreeDesignation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QAAgreeDesignation")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QaagreeEmployee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QAAgreeEmployee")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QaassignGroupId)
                    .HasColumnName("QAAssignGroupID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Qacomments)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("QAComments")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qadate)
                    .HasColumnType("datetime")
                    .HasColumnName("QADate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Qadesignation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QADesignation")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qaemployee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QAEmployee")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QaemployeeCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QAEmployeeCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QaemployeeEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QAEmployeeEmail")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QaemployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QAEmployeeName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qainvestigation)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("QAInvestigation")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QareassignUserId)
                    .HasColumnName("QAReassignUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Qarecommendation)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("QARecommendation")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qarerecommendation)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("QARerecommendation")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReferenceId)
                    .HasColumnName("ReferenceID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.HasOne(d => d.ComplainNature)
                    .WithMany(p => p.PoproductComplainComplainNatures)
                    .HasForeignKey(d => d.ComplainNatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductComplain_ValueList");

                entity.HasOne(d => d.ComplainType)
                    .WithMany(p => p.PoproductComplainComplainTypes)
                    .HasForeignKey(d => d.ComplainTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductComplain_ValueList1");

                entity.HasOne(d => d.PriorityType)
                    .WithMany(p => p.PoproductComplainPriorityTypes)
                    .HasForeignKey(d => d.PriorityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductComplain_ValueList2");

                entity.HasOne(d => d.Reference)
                    .WithMany(p => p.InverseReference)
                    .HasForeignKey(d => d.ReferenceId)
                    .HasConstraintName("FK_ProductComplain_ProductComplain");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.PoproductComplainStatuses)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductComplain_ValueList3");
            });

            modelBuilder.Entity<Ppdetail>(entity =>
            {
                entity.ToTable("PPDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CurrentPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentPriceTwo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentTradeMargin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentTradeMarginTwo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectiveDateTwo).HasColumnType("datetime");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Ph9code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProposedPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProposedPriceTwo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProposedTradeMargin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProposedTradeMarginTwo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasComment("CAM-226,SAM-227,Structure Approval(TCM,BM,CFM)-228");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Ppdetails)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PPDetail_PPMaster");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Ppdetails)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PPDetail_ValueList");
            });

            modelBuilder.Entity<PpdetailAuthoUser>(entity =>
            {
                entity.ToTable("PPDetailAuthoUser");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PpmasterId).HasColumnName("PPMasterID");

                entity.Property(e => e.ProcessTime).HasColumnType("datetime");

                entity.Property(e => e.ProcessType).HasComment("CAM-226,SAM-227");

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.PpdetailAuthoUsers)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PPDetailAuthoUser_PPDetail");
            });

            modelBuilder.Entity<PpdetailQuery>(entity =>
            {
                entity.ToTable("PPDetailQuery");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PpdetailId).HasColumnName("PPDetailID");

                entity.Property(e => e.PpmasterId).HasColumnName("PPMasterID");

                entity.Property(e => e.QueryDate).HasColumnType("datetime");

                entity.Property(e => e.QueryText)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QueryUserId).HasColumnName("QueryUserID");

                entity.Property(e => e.ReplyDate).HasColumnType("datetime");

                entity.Property(e => e.ReplyText)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReplyUserId).HasColumnName("ReplyUserID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.PpdetailQueries)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PPDetailQuery_PPDetailAuthoUser");
            });

            modelBuilder.Entity<PpdetailView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PPDetailView");

                entity.Property(e => e.DetailStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DetailStatusId).HasColumnName("DetailStatusID");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveDateTwo).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDateTwoFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EntryUserName)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MasterStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MasterStatusId).HasColumnName("MasterStatusID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Ph9code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH9Code");

                entity.Property(e => e.Ph9name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PH9Name");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProposalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.SendDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PpemailCirculation>(entity =>
            {
                entity.ToTable("PPEmailCirculation");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Ppmaster>(entity =>
            {
                entity.ToTable("PPMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.ForecastScenarioId).HasColumnName("ForecastScenarioID");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProposalCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasComment("Entry-220,Submit-221,Verify-222,Agree-223,Authorize-224,Circulation-225");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Ppmasters)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PPMaster_ValueList");
            });

            modelBuilder.Entity<PpmasterAuthoUser>(entity =>
            {
                entity.ToTable("PPMasterAuthoUser");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProcessTime).HasColumnType("datetime");

                entity.Property(e => e.ProcessType).HasComment("Initiated-220,Submit-221,Agree-222,Approve-223,Authorize-224,Circulation-225");

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.PpmasterAuthoUsers)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PPMasterAuthoUser_PPMaster");
            });

            modelBuilder.Entity<PpmasterQuery>(entity =>
            {
                entity.ToTable("PPMasterQuery");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PpmasterId).HasColumnName("PPMasterID");

                entity.Property(e => e.QueryDate).HasColumnType("datetime");

                entity.Property(e => e.QueryText)
                    .IsRequired()
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QueryUserId).HasColumnName("QueryUserID");

                entity.Property(e => e.ReplyDate).HasColumnType("datetime");

                entity.Property(e => e.ReplyText)
                    .IsRequired()
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReplyUserId).HasColumnName("ReplyUserID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.PpmasterQueries)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PPMasterQuery_PPMasterAuthoUser");
            });

            modelBuilder.Entity<PpmasterView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PPMasterView");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.EntryUserLoginId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EntryUserLoginID");

                entity.Property(e => e.EntryUserName)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.ForecastScenarioId).HasColumnName("ForecastScenarioID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PendingUsers)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProposalCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.SendDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDetail)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDateFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.Property(e => e.UpdateUserLoginId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UpdateUserLoginID");

                entity.Property(e => e.UpdateUserName)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PpuserProduct>(entity =>
            {
                entity.ToTable("PPUserProduct");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ph8code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.PpuserProducts)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PPUserProduct_ValueList");
            });

            modelBuilder.Entity<PpuserRole>(entity =>
            {
                entity.ToTable("PPUserRole");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IsBbd).HasColumnName("IsBBD");

                entity.Property(e => e.IsBm).HasColumnName("IsBM");

                entity.Property(e => e.IsCam).HasColumnName("IsCAM");

                entity.Property(e => e.IsCdd).HasColumnName("IsCDD");

                entity.Property(e => e.IsCfm).HasColumnName("IsCFM");

                entity.Property(e => e.IsCoo).HasColumnName("IsCOO");

                entity.Property(e => e.IsFd).HasColumnName("IsFD");

                entity.Property(e => e.IsMd).HasColumnName("IsMD");

                entity.Property(e => e.IsPpa).HasColumnName("IsPPA");

                entity.Property(e => e.IsSam).HasColumnName("IsSAM");

                entity.Property(e => e.IsScd).HasColumnName("IsSCD");

                entity.Property(e => e.IsTcm).HasColumnName("IsTCM");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<PrimarySale>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.AdvanceAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Ddvalue)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("DDValue");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.ListPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Lpddprice)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("LPDDPrice");

                entity.Property(e => e.Lpvalue)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("LPValue");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sapskucode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAPSKUCode");

                entity.Property(e => e.Skucode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SKUCode");

                entity.Property(e => e.Skuname)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("SKUName");

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tpcode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TPCode");

                entity.Property(e => e.UoM)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrimarySalesDaily>(entity =>
            {
                entity.ToTable("PrimarySalesDaily");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DamageQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LP");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Mrplp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MRPLP");

                entity.Property(e => e.Mrptp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MRPTP");

                entity.Property(e => e.SalesDate).HasColumnType("datetime");

                entity.Property(e => e.SalesQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Skucode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SKUCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Skuname)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SKUName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TotalQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TP");

                entity.Property(e => e.Tplp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TPLP");
            });

            modelBuilder.Entity<PrimarySalesDetail>(entity =>
            {
                entity.ToTable("PrimarySalesDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DelivaryNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GrossValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsNsd).HasColumnName("IsNSD");

                entity.Property(e => e.ListPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PromotionFlag).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SequenceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOM");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.PrimarySalesDetails)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrimarySalesDetail_PrimarySalesMaster");
            });

            modelBuilder.Entity<PrimarySalesMaster>(entity =>
            {
                entity.ToTable("PrimarySalesMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClaimCreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrossValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDueDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsPodreceived).HasColumnName("IsPODReceived");

                entity.Property(e => e.NetValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Ponumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PONumber");

                entity.Property(e => e.SalesOrganization)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SONumber");

                entity.Property(e => e.Tax).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.VatChallanNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("VATAmount");

                entity.Property(e => e.VatchallanDate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VATChallanDate");
            });

            modelBuilder.Entity<ProductGroup>(entity =>
            {
                entity.ToTable("ProductGroup");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ProductGroupAuthoUser>(entity =>
            {
                entity.ToTable("ProductGroupAuthoUser");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductGroupId).HasColumnName("ProductGroupID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ProductGroup)
                    .WithMany(p => p.ProductGroupAuthoUsers)
                    .HasForeignKey(d => d.ProductGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductGroupAuthoUser_ProductGroup");
            });

            modelBuilder.Entity<ProductGroupSubBrand>(entity =>
            {
                entity.ToTable("ProductGroupSubBrand");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ph8code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH8Code");

                entity.Property(e => e.ProductGroupId).HasColumnName("ProductGroupID");

                entity.HasOne(d => d.ProductGroup)
                    .WithMany(p => p.ProductGroupSubBrands)
                    .HasForeignKey(d => d.ProductGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubBrandGroup_ProductGroup");
            });

            modelBuilder.Entity<Rejection>(entity =>
            {
                entity.ToTable("Rejection");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExecutionDate).HasColumnType("datetime");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ReportDetail>(entity =>
            {
                entity.ToTable("ReportDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BlankRowHeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Equation)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EquationName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExcelEquation)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExcelRowNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.FontBackColor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FontForeColor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FontName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsFormula).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUpguvg).HasColumnName("IsUPGUVG");

                entity.Property(e => e.MeasureId)
                    .HasColumnName("MeasureID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ReportDetails)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportDetail_ReportMaster");
            });

            modelBuilder.Entity<ReportDetailFormula>(entity =>
            {
                entity.ToTable("ReportDetailFormula");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FormulaValue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ReportDetailFormulas)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportDetailFormula_ReportDetail");
            });

            modelBuilder.Entity<ReportMaster>(entity =>
            {
                entity.ToTable("ReportMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUpguvg).HasColumnName("IsUPGUVG");

                entity.Property(e => e.Mtvalue).HasColumnName("MTvalue");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<ResearchType>(entity =>
            {
                entity.ToTable("ResearchType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ResearchTypeId).HasColumnName("ResearchTypeID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.HasOne(d => d.ResearchTypeNavigation)
                    .WithMany(p => p.ResearchTypes)
                    .HasForeignKey(d => d.ResearchTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResearchType_ValueList");
            });

            modelBuilder.Entity<Sapioallocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SAPIOAllocation");

                entity.Property(e => e.Aac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AAC");

                entity.Property(e => e.Banner)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandPh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BrandPH");

                entity.Property(e => e.Bs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BS");

                entity.Property(e => e.Category)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cgp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CGP");

                entity.Property(e => e.Coc1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COC1");

                entity.Property(e => e.Coc2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COC2");

                entity.Property(e => e.Coc3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COC3");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControllingArea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndofWork)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalOrder)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ifsc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IFSC");

                entity.Property(e => e.Kcc1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KCC1");

                entity.Property(e => e.Kcc2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KCC2");

                entity.Property(e => e.Kcc3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KCC3");

                entity.Property(e => e.Ll1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LL1");

                entity.Property(e => e.Ll2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LL2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ll3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LL3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Market)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Oh2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OH2");

                entity.Property(e => e.Oh4)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OH4");

                entity.Property(e => e.OrderType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PA");

                entity.Property(e => e.PackSize)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PersonResponsible)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessingGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Product)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitCenter)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitabilityUnit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalesDistrict)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOrg)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryCustomer)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sector)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementPercentageRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Sexternal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SExternal");

                entity.Property(e => e.ShortText)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sorder)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOrder");

                entity.Property(e => e.SubBrandPh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SubBrandPH");

                entity.Property(e => e.Subdivision2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tfc1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TFC1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tfc12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TFC12")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WorkStart)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Scenario>(entity =>
            {
                entity.ToTable("Scenario");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<SecondarySale>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalesValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesVolume).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<SendEmailQueue>(entity =>
            {
                entity.ToTable("SendEmailQueue");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.MailBody)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MailSubject)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MailTo)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QueuedDate).HasColumnType("datetime");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Smsmaster>(entity =>
            {
                entity.ToTable("SMSMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.KeyCode)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ValueText)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SoaTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SOA_Temp");

                entity.Property(e => e.Abtype)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ABType");

                entity.Property(e => e.ActivityType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AgreeUsers)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveUsers)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizeUsers)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HierarchyLevel)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NegativeRoi)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NegativeROI");

                entity.Property(e => e.Retrospective)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Rmfund)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RMFund");

                entity.Property(e => e.Sku)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SKU");

                entity.Property(e => e.SlabDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SlabMaxValue)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SoaTemp2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SOA_Temp_2");

                entity.Property(e => e.Abtype)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ABType");

                entity.Property(e => e.ActivityType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Grcode).HasColumnName("GRCode");

                entity.Property(e => e.HierarchyLevel)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NegativeRoi)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NegativeROI");

                entity.Property(e => e.Retrospective)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Rmfund)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RMFund");

                entity.Property(e => e.Sku)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SKU");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("Supplier");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abmodules)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ABModules");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ContactPerson)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasColumnName("EntryUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<TempSoa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempSOA");

                entity.Property(e => e.ApproverTypeId).HasColumnName("ApproverTypeID");

                entity.Property(e => e.SlabAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempWipamountDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempWIPAmountDetail");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Wipamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("WIPAmount");
            });

            modelBuilder.Entity<ThisSystem>(entity =>
            {
                entity.ToTable("ThisSystem");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AbabsoluteValue)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ABAbsoluteValue");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ait)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AIT");

                entity.Property(e => e.AitlastCloseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("AITLastCloseDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Aitpercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AITPercentage");

                entity.Property(e => e.AnpadminId).HasColumnName("ANPAdminID");

                entity.Property(e => e.AnpfollowUpUserId).HasColumnName("ANPFollowUpUserID");

                entity.Property(e => e.AutoBatchProcessDay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BmilocalMeasureId).HasColumnName("BMILocalMeasureID");

                entity.Property(e => e.CanPromtAbs).HasColumnName("CanPromtABS");

                entity.Property(e => e.CeouserId).HasColumnName("CEOUserID");

                entity.Property(e => e.ChargeDocumentType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SA')");

                entity.Property(e => e.ChargePostingKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((40))");

                entity.Property(e => e.ChgPayEnDt).HasColumnType("datetime");

                entity.Property(e => e.ChgPayStDt).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimContraAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClosingLockMonth)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CollectionGlcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CollectionGLCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B001')");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyProfitCentre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ControllingArea)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SG02')");

                entity.Property(e => e.CostElement)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DamageAbnumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DamageABNumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DamageCbt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DamageCBT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DefaultReviewUserId).HasColumnName("DefaultReviewUserID");

                entity.Property(e => e.DigitalCostCenter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DigitalGlcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DigitalGLCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DigitalServiceNumber)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DistributionChannel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((11))");

                entity.Property(e => e.Division)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((11))");

                entity.Property(e => e.ExternalOrderNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('IBP')");

                entity.Property(e => e.FduserId).HasColumnName("FDUserID");

                entity.Property(e => e.GmmeasureId).HasColumnName("GMMeasureID");

                entity.Property(e => e.GpmeasureId).HasColumnName("GPMeasureID");

                entity.Property(e => e.GsvmeasureId).HasColumnName("GSVMeasureID");

                entity.Property(e => e.Guidate)
                    .HasColumnType("datetime")
                    .HasColumnName("GUIDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Guiserial)
                    .HasColumnName("GUISerial")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdentifiesForStatisticalOrders)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.Iotype)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IOType")
                    .HasDefaultValueSql("('UN13')");

                entity.Property(e => e.IsNfdapproval).HasColumnName("IsNFDApproval");

                entity.Property(e => e.Mdid).HasColumnName("MDID");

                entity.Property(e => e.MsgForAll)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NegativeRoiuser1)
                    .HasColumnName("NegativeROIUser1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NegativeRoiuser2)
                    .HasColumnName("NegativeROIUser2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nsdabnumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NSDABNumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nsdcbt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NSDCBT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OmexpTypeId).HasColumnName("OMExpTypeID");

                entity.Property(e => e.Omlimit)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("OMLimit");

                entity.Property(e => e.OtherCommodity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OtherGlcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OtherGLCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaymentDocumentType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('KR')");

                entity.Property(e => e.PaymentGlcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PaymentGLCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaymentProvisionPostingKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((40))");

                entity.Property(e => e.PaymentTaxCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((50))");

                entity.Property(e => e.PaymentVendorPostingKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((31))");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PressCommodity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PressCostCenter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PressGlcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PressGLCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PressServiceNumber)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProvisionPostingKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((50))");

                entity.Property(e => e.RadioCommodity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RadioCostCenter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RadioGlcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RadioGLCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RadioServiceNumber)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RspmeasureId).HasColumnName("RSPMeasureID");

                entity.Property(e => e.SalesDocumentType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('YCR')");

                entity.Property(e => e.SalesOrg)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ScenarioIdBmi).HasColumnName("ScenarioIdBMI");

                entity.Property(e => e.TargetQuantity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TmmeasureId).HasColumnName("TMMeasureID");

                entity.Property(e => e.TmpmeasureId).HasColumnName("TMPMeasureID");

                entity.Property(e => e.TtsadminId).HasColumnName("TTSAdminID");

                entity.Property(e => e.TtscppmeasureId).HasColumnName("TTSCPPMeasureID");

                entity.Property(e => e.TtscsmeasureId).HasColumnName("TTSCSMeasureID");

                entity.Property(e => e.TtsddmeasureId).HasColumnName("TTSDDMeasureID");

                entity.Property(e => e.TtseotefficientOrderMeasureId).HasColumnName("TTSEOTEfficientOrderMeasureID");

                entity.Property(e => e.TtseotpaymentMeasureId).HasColumnName("TTSEOTPaymentMeasureID");

                entity.Property(e => e.TtseotpromptMeasureId).HasColumnName("TTSEOTPromptMeasureID");

                entity.Property(e => e.TtsfollowUpUserId).HasColumnName("TTSFollowUpUserID");

                entity.Property(e => e.TtspackMeasureId).HasColumnName("TTSPackMeasureID");

                entity.Property(e => e.TtsplaceMeasureId).HasColumnName("TTSPlaceMeasureID");

                entity.Property(e => e.TtsproductMeasureId).HasColumnName("TTSProductMeasureID");

                entity.Property(e => e.TtspromotionMeasureId).HasColumnName("TTSPromotionMeasureID");

                entity.Property(e => e.TtspropositionMeasureId).HasColumnName("TTSPropositionMeasureID");

                entity.Property(e => e.TtsromeasureId).HasColumnName("TTSROMeasureID");

                entity.Property(e => e.TurnoverMeasureId).HasColumnName("TurnoverMeasureID");

                entity.Property(e => e.Tvcommodity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TVCommodity")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TvcostCenter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TVCostCenter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tvglcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TVGLCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TvserviceNumber)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("TVServiceNumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UblscbbankAccountNo)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("UBLSCBBankAccountNo")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VAT");

                entity.Property(e => e.VolumeMeasureId).HasColumnName("VolumeMeasureID");

                entity.Property(e => e.WorkingDays).HasDefaultValueSql("((26))");
            });

            modelBuilder.Entity<TimelineView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TimelineView");

                entity.Property(e => e.EffectiveDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastPriceChangeDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Skus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SKUs");
            });

            modelBuilder.Entity<TmrsmforUnibd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TMRSMForUnibd");

                entity.Property(e => e.DistributorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorId).HasColumnName("DistributorID");

                entity.Property(e => e.Rsm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RSM");

                entity.Property(e => e.Rsmname)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false)
                    .HasColumnName("RSMName");

                entity.Property(e => e.Sapcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAPCode");

                entity.Property(e => e.Tm).HasColumnName("TM");

                entity.Property(e => e.Tmname)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false)
                    .HasColumnName("TMName");
            });

            modelBuilder.Entity<Ttsbscbtview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TTSBSCBTView");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.ActivityEndDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityStartDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.ActualAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Initiator)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ioamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IOAmount");

                entity.Property(e => e.Ioid).HasColumnName("IOID");

                entity.Property(e => e.Ionumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("IONumber");

                entity.Property(e => e.IsJvcreate).HasColumnName("IsJVCreate");

                entity.Property(e => e.Jv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("JV");

                entity.Property(e => e.JvcreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JVCreateDate");

                entity.Property(e => e.PnLcbt)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PnLCBT");
            });

            modelBuilder.Entity<TtspnLcbtview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TTSPnLCBTView");

                entity.Property(e => e.Abnumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ABNumber");

                entity.Property(e => e.ActivityEndDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityStartDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.ActualAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Initiator)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ioamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IOAmount");

                entity.Property(e => e.Ioid).HasColumnName("IOID");

                entity.Property(e => e.Ionumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("IONumber");

                entity.Property(e => e.IsJvcreate).HasColumnName("IsJVCreate");

                entity.Property(e => e.Jv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("JV");

                entity.Property(e => e.JvcreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JVCreateDate");

                entity.Property(e => e.PnLcbt)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PnLCBT");
            });

            modelBuilder.Entity<UnibdClaim>(entity =>
            {
                entity.ToTable("unibdClaim");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abnumbers)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ABNumbers");

                entity.Property(e => e.CdapproveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CDApproveDate");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimCategoryId).HasColumnName("ClaimCategoryID");

                entity.Property(e => e.ClaimDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimMasterId).HasColumnName("ClaimMasterID");

                entity.Property(e => e.ClaimNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimTypeId)
                    .HasColumnName("ClaimTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Comments)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DepotCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.SettledDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TmapproveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TMApproveDate");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.TownName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserName)
                    .HasMaxLength(800)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UpdatedProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__UpdatedP__B40CC6ED3079A153");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("money");
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.ToTable("UserDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.IsAbright).HasColumnName("IsABRight");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UserLimit>(entity =>
            {
                entity.ToTable("UserLimit");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abtype).HasColumnName("ABType");

                entity.Property(e => e.ExpenditureId).HasColumnName("ExpenditureID");

                entity.Property(e => e.FinancialLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UserLimitModule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UserLimitModules");

                entity.Property(e => e.Abtype).HasColumnName("ABType");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserPermitionReportView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UserPermitionReportView");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.ScreenName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ValueList>(entity =>
            {
                entity.ToTable("ValueList");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ValueTypeDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
