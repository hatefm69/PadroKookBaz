using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PerWrkLst
    {
        public int PerPrsnlSi { get; set; }
        public int PerPyrlPeriodSi { get; set; }
        public string PerWrkLstCu { get; set; }
        public string PerWrkLstTp { get; set; }
        public double PerWrkLstValue { get; set; }

        public virtual PerPrsnl PerPrsnlSiNavigation { get; set; }
        public virtual PerPyrlPeriod PerPyrlPeriodSiNavigation { get; set; }
    }
}
