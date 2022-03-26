using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ValueList
    {
        public ValueList()
        {
            Abdetails = new HashSet<Abdetail>();
            AbslabUsers = new HashSet<AbslabUser>();
            Absoamasters = new HashSet<Absoamaster>();
            AbsoanegativeRois = new HashSet<AbsoanegativeRoi>();
            ClaimAllocationRules = new HashSet<ClaimAllocationRule>();
            ClaimBudgetNoAbs = new HashSet<ClaimBudgetNoAb>();
            ClaimCmsalaryStructureCategories = new HashSet<ClaimCmsalaryStructure>();
            ClaimCmsalaryStructureGrades = new HashSet<ClaimCmsalaryStructure>();
            ClaimDds = new HashSet<ClaimDd>();
            ClaimDffs = new HashSet<ClaimDff>();
            ClaimDigradeGroupGrades = new HashSet<ClaimDigradeGroup>();
            ClaimDigradeGroupGroups = new HashSet<ClaimDigradeGroup>();
            ClaimDiparamMasterJoinTypes = new HashSet<ClaimDiparamMaster>();
            ClaimDiparamMasterParamTypes = new HashSet<ClaimDiparamMaster>();
            ClaimDiparamMasterPhlevels = new HashSet<ClaimDiparamMaster>();
            ClaimDiparamMasterSalesTypes = new HashSet<ClaimDiparamMaster>();
            ClaimDiprocessDatumGrades = new HashSet<ClaimDiprocessDatum>();
            ClaimDiprocessDatumGroups = new HashSet<ClaimDiprocessDatum>();
            ClaimDiprocessDatumParamTypes = new HashSet<ClaimDiprocessDatum>();
            ClaimJvddicollections = new HashSet<ClaimJvddicollection>();
            ClaimJvpayments = new HashSet<ClaimJvpayment>();
            ClaimMasterClaimTypes = new HashSet<ClaimMaster>();
            ClaimMasterStatuses = new HashSet<ClaimMaster>();
            ClaimSoaClaimCategories = new HashSet<ClaimSoa>();
            ClaimSoaUserTypes = new HashSet<ClaimSoa>();
            ClaimTypeTags = new HashSet<ClaimTypeTag>();
            DdclaimMasters = new HashSet<DdclaimMaster>();
            LocationEmployee2s = new HashSet<LocationEmployee2>();
            ModuleGls = new HashSet<ModuleGl>();
            PoproductComplainComplainNatures = new HashSet<PoproductComplain>();
            PoproductComplainComplainTypes = new HashSet<PoproductComplain>();
            PoproductComplainPriorityTypes = new HashSet<PoproductComplain>();
            PoproductComplainStatuses = new HashSet<PoproductComplain>();
            Ppdetails = new HashSet<Ppdetail>();
            Ppmasters = new HashSet<Ppmaster>();
            PpuserProducts = new HashSet<PpuserProduct>();
            ResearchTypes = new HashSet<ResearchType>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int ValueType { get; set; }
        public string ValueTypeDescription { get; set; }
        public int Position { get; set; }

        public virtual ICollection<Abdetail> Abdetails { get; set; }
        public virtual ICollection<AbslabUser> AbslabUsers { get; set; }
        public virtual ICollection<Absoamaster> Absoamasters { get; set; }
        public virtual ICollection<AbsoanegativeRoi> AbsoanegativeRois { get; set; }
        public virtual ICollection<ClaimAllocationRule> ClaimAllocationRules { get; set; }
        public virtual ICollection<ClaimBudgetNoAb> ClaimBudgetNoAbs { get; set; }
        public virtual ICollection<ClaimCmsalaryStructure> ClaimCmsalaryStructureCategories { get; set; }
        public virtual ICollection<ClaimCmsalaryStructure> ClaimCmsalaryStructureGrades { get; set; }
        public virtual ICollection<ClaimDd> ClaimDds { get; set; }
        public virtual ICollection<ClaimDff> ClaimDffs { get; set; }
        public virtual ICollection<ClaimDigradeGroup> ClaimDigradeGroupGrades { get; set; }
        public virtual ICollection<ClaimDigradeGroup> ClaimDigradeGroupGroups { get; set; }
        public virtual ICollection<ClaimDiparamMaster> ClaimDiparamMasterJoinTypes { get; set; }
        public virtual ICollection<ClaimDiparamMaster> ClaimDiparamMasterParamTypes { get; set; }
        public virtual ICollection<ClaimDiparamMaster> ClaimDiparamMasterPhlevels { get; set; }
        public virtual ICollection<ClaimDiparamMaster> ClaimDiparamMasterSalesTypes { get; set; }
        public virtual ICollection<ClaimDiprocessDatum> ClaimDiprocessDatumGrades { get; set; }
        public virtual ICollection<ClaimDiprocessDatum> ClaimDiprocessDatumGroups { get; set; }
        public virtual ICollection<ClaimDiprocessDatum> ClaimDiprocessDatumParamTypes { get; set; }
        public virtual ICollection<ClaimJvddicollection> ClaimJvddicollections { get; set; }
        public virtual ICollection<ClaimJvpayment> ClaimJvpayments { get; set; }
        public virtual ICollection<ClaimMaster> ClaimMasterClaimTypes { get; set; }
        public virtual ICollection<ClaimMaster> ClaimMasterStatuses { get; set; }
        public virtual ICollection<ClaimSoa> ClaimSoaClaimCategories { get; set; }
        public virtual ICollection<ClaimSoa> ClaimSoaUserTypes { get; set; }
        public virtual ICollection<ClaimTypeTag> ClaimTypeTags { get; set; }
        public virtual ICollection<DdclaimMaster> DdclaimMasters { get; set; }
        public virtual ICollection<LocationEmployee2> LocationEmployee2s { get; set; }
        public virtual ICollection<ModuleGl> ModuleGls { get; set; }
        public virtual ICollection<PoproductComplain> PoproductComplainComplainNatures { get; set; }
        public virtual ICollection<PoproductComplain> PoproductComplainComplainTypes { get; set; }
        public virtual ICollection<PoproductComplain> PoproductComplainPriorityTypes { get; set; }
        public virtual ICollection<PoproductComplain> PoproductComplainStatuses { get; set; }
        public virtual ICollection<Ppdetail> Ppdetails { get; set; }
        public virtual ICollection<Ppmaster> Ppmasters { get; set; }
        public virtual ICollection<PpuserProduct> PpuserProducts { get; set; }
        public virtual ICollection<ResearchType> ResearchTypes { get; set; }
    }
}
