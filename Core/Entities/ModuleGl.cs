using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ModuleGl
    {
        public ModuleGl()
        {
            Absoamasters = new HashSet<Absoamaster>();
        }

        public int Id { get; set; }
        public string ChargeCode { get; set; }
        public string ChargeDescription { get; set; }
        public string ProvisionCode { get; set; }
        public string ProvisionDescription { get; set; }
        public string PaymentCode { get; set; }
        public string PaymentDescription { get; set; }
        public int AbtypeId { get; set; }
        public int? ActivityTypeId { get; set; }
        public string FunctionalArea { get; set; }

        public virtual Module Abtype { get; set; }
        public virtual ValueList ActivityType { get; set; }
        public virtual ICollection<Absoamaster> Absoamasters { get; set; }
    }
}
