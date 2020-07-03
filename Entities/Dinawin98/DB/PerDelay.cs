using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PerDelay
    {
        public int PerDelaySi { get; set; }
        public int? PerPrsnlSi { get; set; }
        public int? PerPyrlPeriodSi { get; set; }
        public string PerOprCu { get; set; }
    }
}
