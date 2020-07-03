using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalRegionToSalResp
    {
        public int SalRegionToSalRespSi { get; set; }
        public int? SalRespSi { get; set; }
        public int? SalRegionSi { get; set; }
        public DateTime? SalRegionToSalRespDs { get; set; }
        public bool? SalRegionToSalRespAct { get; set; }
    }
}
