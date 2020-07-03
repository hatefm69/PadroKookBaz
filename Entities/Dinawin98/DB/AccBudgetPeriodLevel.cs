using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccBudgetPeriodLevel
    {
        public AccBudgetPeriodLevel()
        {
            AccBudgetLog = new HashSet<AccBudgetLog>();
            AccBudgetPeriod = new HashSet<AccBudgetPeriod>();
        }

        public int AccBudgetPeriodLevelSi { get; set; }
        public string AccBudgetPeriodLevelCu { get; set; }
        public string AccBudgetPeriodLevelName { get; set; }
        public bool? AccBudgetPeriodLevelIsActive { get; set; }
        public bool? AccBudgetPeriodLevelIsRevisionBase { get; set; }

        public virtual ICollection<AccBudgetLog> AccBudgetLog { get; set; }
        public virtual ICollection<AccBudgetPeriod> AccBudgetPeriod { get; set; }
    }
}
