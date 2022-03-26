using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class PoproductComplain
    {
        public PoproductComplain()
        {
            InverseReference = new HashSet<PoproductComplain>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public int? ReferenceId { get; set; }
        public string Employee { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string OfficeLocation { get; set; }
        public string GeographicLocation { get; set; }
        public string Product { get; set; }
        public string ManufacturingUnit { get; set; }
        public string PackingCode { get; set; }
        public string BatchCode { get; set; }
        public int ComplainNatureId { get; set; }
        public int ComplainTypeId { get; set; }
        public int PriorityTypeId { get; set; }
        public string Details { get; set; }
        public bool SampleSent { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
        public string Picture4 { get; set; }
        public int StatusId { get; set; }
        public int? QaassignGroupId { get; set; }
        public string Qaemployee { get; set; }
        public string Qadesignation { get; set; }
        public DateTime? Qadate { get; set; }
        public string QaemployeeName { get; set; }
        public string QaemployeeEmail { get; set; }
        public string QaemployeeCode { get; set; }
        public string Qainvestigation { get; set; }
        public string QaactionTaken { get; set; }
        public string Qacomments { get; set; }
        public string Qarecommendation { get; set; }
        public int? ProductionUserId { get; set; }
        public string ProductionEmployee { get; set; }
        public string ProductionDesignation { get; set; }
        public DateTime? ProductionDate { get; set; }
        public string ProductionInvestigation { get; set; }
        public string ProductionActionTaken { get; set; }
        public string ProductionComments { get; set; }
        public string QaactionAgree { get; set; }
        public string Qarerecommendation { get; set; }
        public string QaagreeComments { get; set; }
        public int? QareassignUserId { get; set; }
        public string QaagreeEmployee { get; set; }
        public string QaagreeDesignation { get; set; }
        public DateTime? QaagreeDate { get; set; }
        public string FinalComments { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ValueList ComplainNature { get; set; }
        public virtual ValueList ComplainType { get; set; }
        public virtual ValueList PriorityType { get; set; }
        public virtual PoproductComplain Reference { get; set; }
        public virtual ValueList Status { get; set; }
        public virtual ICollection<PoproductComplain> InverseReference { get; set; }
    }
}
