using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClaimDistributorPlant
    {
        public int Id { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string CustomerName { get; set; }
        public string SalesRegion { get; set; }
        public string PlantSapcode { get; set; }
        public string DepotName { get; set; }
        public string DepotCode { get; set; }
    }
}
