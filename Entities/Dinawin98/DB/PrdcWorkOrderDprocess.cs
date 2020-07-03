using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PrdcWorkOrderDprocess
    {
        public int PrdcWorkOrderDprocessSi { get; set; }
        public int? PrdcWorkOrderDinfoSi { get; set; }
        public int? CtbCostSi { get; set; }
        public int? PrdcStationSi { get; set; }
        public double? PrdcWorkOrderDprocessMachineTime { get; set; }
        public double? PrdcWorkOrderDprocessHumanTime { get; set; }
        public double? PrdcWorkOrderDprocessContractorTime { get; set; }
        public int? PrdcLineSi { get; set; }

        public virtual CtbCost CtbCostSiNavigation { get; set; }
        public virtual PrdcStation PrdcStationSiNavigation { get; set; }
        public virtual PrdcWorkOrderDinfo PrdcWorkOrderDinfoSiNavigation { get; set; }
    }
}
