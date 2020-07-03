using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccBudgetPeriodLog
    {
        public int AccBudgetPeriodLogSi { get; set; }
        public int AccBudgetPeriodSi { get; set; }
        public double? AccBudgetPeriodPrcNew { get; set; }
        public double? AccBudgetPeriodPrcOld { get; set; }
        public double? AccBudgetPeriodChangePrc { get; set; }
        public int? AccBudgetPeriodLevelSi { get; set; }

        public virtual AccBudgetPeriod AccBudgetPeriodSiNavigation { get; set; }
    }
}
