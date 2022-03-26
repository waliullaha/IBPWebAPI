using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class LocationEmployeeVertically
    {
        public int DistributorId { get; set; }
        public string DistributorCode { get; set; }
        public string Distributor { get; set; }
        public string Sapcode { get; set; }
        public string DistributorEmail { get; set; }
        public int TerritoryId { get; set; }
        public string TerritoryCode { get; set; }
        public string Territory { get; set; }
        public int AreaId { get; set; }
        public string AreaCode { get; set; }
        public string Area { get; set; }
        public int RegionId { get; set; }
        public string RegionCode { get; set; }
        public string Region { get; set; }
        public string Tm { get; set; }
        public string Asm { get; set; }
        public string Rsm { get; set; }
        public int? TerritoryLocationTypeId { get; set; }
        public int? AreaLocationTypeId { get; set; }
        public int? RegionLocationTypeId { get; set; }
    }
}
