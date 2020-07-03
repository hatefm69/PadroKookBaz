using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccBudgetLog
    {
        public int AccBudgetLogSi { get; set; }
        public int AccBudgetSi { get; set; }
        public double AccBudgetLogPrcNew { get; set; }
        public double AccBudgetLogPrcOld { get; set; }
        public double AccBudgetLogChangePrc { get; set; }
        public int AccBudgetPeriodLevelSi { get; set; }
        public bool AccBudgetPeriodLevelIsNewRow { get; set; }

        public virtual AccBudgetPeriodLevel AccBudgetPeriodLevelSiNavigation { get; set; }
        public virtual AccBudget AccBudgetSiNavigation { get; set; }
    }
}
