using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PerLoanGivBak
    {
        public int PerLoanGivBakSi { get; set; }
        public int PerLoanSi { get; set; }
        public string PerLoanGivBakDs { get; set; }
        public decimal PerLoanGivBakPrice { get; set; }
        public string PerLoanGivBakTp { get; set; }
        public int? PerPyrlPeriodSi { get; set; }

        public virtual PerLoans PerLoanSiNavigation { get; set; }
        public virtual PerPyrlPeriod PerPyrlPeriodSiNavigation { get; set; }
    }
}
