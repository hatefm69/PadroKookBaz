using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PrdcTraceDprocess
    {
        public int PrdcTraceDprocessSi { get; set; }
        public int? PrdcTraceDinfoSi { get; set; }
        public int? CtbCostSi { get; set; }
        public int? PrdcStationSi { get; set; }
        public int? PrdcTraceDprocessMachineTime { get; set; }
        public int? PrdcTraceDprocessHumanTime { get; set; }
        public int? PrdcTraceDprocessContractor { get; set; }
        public int? PrdcWorkOrderDprocessSi { get; set; }

        public virtual CtbCost CtbCostSiNavigation { get; set; }
        public virtual PrdcStation PrdcStationSiNavigation { get; set; }
        public virtual PrdcTraceDinfo PrdcTraceDinfoSiNavigation { get; set; }
    }
}
