using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class ClosingIodetail
    {
        public int Id { get; set; }
        public int Ioid { get; set; }
        public int ClosingYear { get; set; }
        public int ClosingMonth { get; set; }
        public int ActivityTypeId { get; set; }
        public string PnLcbt { get; set; }
        public string ProvisionCbt { get; set; }
        public bool IsChargeCbt { get; set; }
        public decimal JanuaryJv { get; set; }
        public decimal JanuaryYtd { get; set; }
        public decimal JanuaryCharge { get; set; }
        public decimal FebruaryJv { get; set; }
        public decimal FebruaryYtd { get; set; }
        public decimal FebruaryCharge { get; set; }
        public decimal MarchJv { get; set; }
        public decimal MarchYtd { get; set; }
        public decimal MarchCharge { get; set; }
        public decimal AprilJv { get; set; }
        public decimal AprilYtd { get; set; }
        public decimal AprilCharge { get; set; }
        public decimal MayJv { get; set; }
        public decimal MayYtd { get; set; }
        public decimal MayCharge { get; set; }
        public decimal JuneJv { get; set; }
        public decimal JuneYtd { get; set; }
        public decimal JuneCharge { get; set; }
        public decimal JulyJv { get; set; }
        public decimal JulyYtd { get; set; }
        public decimal JulyCharge { get; set; }
        public decimal AugustJv { get; set; }
        public decimal AugustYtd { get; set; }
        public decimal AugustCharge { get; set; }
        public decimal SeptemberJv { get; set; }
        public decimal SeptemberYtd { get; set; }
        public decimal SeptemberCharge { get; set; }
        public decimal OctoberJv { get; set; }
        public decimal OctoberYtd { get; set; }
        public decimal OctoberCharge { get; set; }
        public decimal NovemberJv { get; set; }
        public decimal NovemberYtd { get; set; }
        public decimal NovemberCharge { get; set; }
        public decimal DecemberJv { get; set; }
        public decimal DecemberYtd { get; set; }
        public decimal DecemberCharge { get; set; }
        public int Jvnumber { get; set; }
        public bool IsJvcreate { get; set; }
        public DateTime? JvcreateDate { get; set; }

        public virtual ClosingIomaster Io { get; set; }
    }
}
