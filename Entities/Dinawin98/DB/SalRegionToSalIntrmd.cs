using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalRegionToSalIntrmd
    {
        public int SalRegionToSalIntrmdSi { get; set; }
        public int? SalIntrmdSi { get; set; }
        public int? SalRegionPathSi { get; set; }
        public int? SalRegionSi { get; set; }
        public DateTime? SalRegionToSalIntrmdFrmDs { get; set; }
        public DateTime? SalRegionToSalIntrmdToDs { get; set; }
        public bool? SalRegionToSalIntrmdAct { get; set; }
    }
}
