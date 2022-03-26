using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Module
    {
        public Module()
        {
            Absoamasters = new HashSet<Absoamaster>();
            ClaimTypeTags = new HashSet<ClaimTypeTag>();
            ModuleGls = new HashSet<ModuleGl>();
        }

        public int Id { get; set; }
        public int Position { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public int ClosureDays { get; set; }
        public bool CanAuthoOwnAb { get; set; }
        public decimal ApprovalLimit { get; set; }
        public int AuthoriseDay { get; set; }
        public int? LessUserId { get; set; }
        public int? GreaterUserId { get; set; }
        public int? LessAuthoriseUserId { get; set; }
        public int? GreaterAuthoriseUserId { get; set; }
        public bool IsActive { get; set; }
        public bool IsAuthoriseActive { get; set; }
        public decimal EvaluationLimit { get; set; }
        public bool IsActiveEvaluation { get; set; }
        public int? GreaterAgreeUserId { get; set; }
        public int? MbreviewUserId { get; set; }
        public int? UnbudgetAuthoUserId1 { get; set; }
        public int? UnbudgetAuthoUserId2 { get; set; }
        public string ProcessingGroup { get; set; }
        public string AgreeUserIds { get; set; }
        public string AgreeLogInIds { get; set; }
        public bool IsUseModuleUser { get; set; }
        public string Sapuser { get; set; }
        public string CostElement { get; set; }
        public string Iotype { get; set; }
        public int ApprovedDays { get; set; }
        public int CompanyId { get; set; }

        public virtual ICollection<Absoamaster> Absoamasters { get; set; }
        public virtual ICollection<ClaimTypeTag> ClaimTypeTags { get; set; }
        public virtual ICollection<ModuleGl> ModuleGls { get; set; }
    }
}
