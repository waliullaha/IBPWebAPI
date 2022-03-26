using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Ppdetail
    {
        public Ppdetail()
        {
            PpdetailAuthoUsers = new HashSet<PpdetailAuthoUser>();
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Ph9code { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? EffectiveDateTwo { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal CurrentPriceTwo { get; set; }
        public decimal ProposedPrice { get; set; }
        public decimal ProposedPriceTwo { get; set; }
        public decimal CurrentTradeMargin { get; set; }
        public decimal CurrentTradeMarginTwo { get; set; }
        public decimal ProposedTradeMargin { get; set; }
        public decimal ProposedTradeMarginTwo { get; set; }
        public int SelectedOption { get; set; }
        public int SelectedOptionTwo { get; set; }
        /// <summary>
        /// CAM-226,SAM-227,Structure Approval(TCM,BM,CFM)-228
        /// </summary>
        public int StatusId { get; set; }

        public virtual Ppmaster Parent { get; set; }
        public virtual ValueList Status { get; set; }
        public virtual ICollection<PpdetailAuthoUser> PpdetailAuthoUsers { get; set; }
    }
}
