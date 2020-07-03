using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class BgtChangeCostH
    {
        public BgtChangeCostH()
        {
            BgtChangeCostD = new HashSet<BgtChangeCostD>();
        }

        public int BgtChangeCostHSi { get; set; }
        public int? CtbCostSi { get; set; }
        public byte? BgtChangeCostHMonthCoef { get; set; }

        public virtual CtbCost CtbCostSiNavigation { get; set; }
        public virtual ICollection<BgtChangeCostD> BgtChangeCostD { get; set; }
    }
}
