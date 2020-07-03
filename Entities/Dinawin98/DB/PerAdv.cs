using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PerAdv
    {
        public int PerAdvSi { get; set; }
        public int PerPrsnlSi { get; set; }
        public int? PerAdvCu { get; set; }
        public string PerAdvDs { get; set; }
        public string PerAdvTp { get; set; }
        public decimal PerAdvPrice { get; set; }
        public int? PerPyrlPeriodSi { get; set; }

        public virtual PerPrsnl PerPrsnlSiNavigation { get; set; }
        public virtual PerPyrlPeriod PerPyrlPeriodSiNavigation { get; set; }
    }
}
