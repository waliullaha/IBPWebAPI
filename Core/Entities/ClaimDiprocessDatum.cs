using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimDiprocessDatum
    {
        public int Id { get; set; }
        public int ParamMasterId { get; set; }
        public int ParamTypeId { get; set; }
        public int GradeId { get; set; }
        public int GroupId { get; set; }
        public int SlabId { get; set; }
        public int Months { get; set; }
        public int Years { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public decimal Target { get; set; }
        public decimal TargetValue { get; set; }
        public decimal MinimumIncAmount { get; set; }
        public decimal MinimumFlatAmount { get; set; }
        public decimal MaximumIncAmount { get; set; }
        public decimal MaximumFlatAmount { get; set; }
        public decimal Acheivement { get; set; }
        public decimal AchivementAmount { get; set; }
        public DateTime ProcessDate { get; set; }
        public bool IsTransfer { get; set; }
        public DateTime? TransferDate { get; set; }

        public virtual ValueList Grade { get; set; }
        public virtual ValueList Group { get; set; }
        public virtual ClaimDiparamMaster ParamMaster { get; set; }
        public virtual ValueList ParamType { get; set; }
        public virtual ClaimDiparamSlab Slab { get; set; }
    }
}
