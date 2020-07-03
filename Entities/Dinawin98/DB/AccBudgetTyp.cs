using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccBudgetTyp
    {
        public AccBudgetTyp()
        {
            AccBudget = new HashSet<AccBudget>();
        }

        public int AccBudgetTypSi { get; set; }
        public string AccBudgetTypTp { get; set; }

        public virtual ICollection<AccBudget> AccBudget { get; set; }
    }
}
