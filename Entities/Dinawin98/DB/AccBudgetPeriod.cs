using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccBudgetPeriod
    {
        public AccBudgetPeriod()
        {
            AccBudgetPeriodLog = new HashSet<AccBudgetPeriodLog>();
        }

        public int AccBudgetPeriodSi { get; set; }
        public int AccBudgetSi { get; set; }
        public int AccBudgetPeriodLevelSi { get; set; }
        public double AccBudgetPeriodPrice { get; set; }

        public virtual AccBudgetPeriodLevel AccBudgetPeriodLevelSiNavigation { get; set; }
        public virtual ICollection<AccBudgetPeriodLog> AccBudgetPeriodLog { get; set; }
    }
}
