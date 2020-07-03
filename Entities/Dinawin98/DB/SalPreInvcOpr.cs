using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalPreInvcOpr
    {
        public int SalPreInvcOprSi { get; set; }
        public int SalPreInvcHSi { get; set; }
        public int SalOprSi { get; set; }
        public decimal SalPreInvcOprValue { get; set; }
        public decimal SalPreInvcOprCalcValue { get; set; }

        public virtual SalOpr SalOprSiNavigation { get; set; }
        public virtual SalPreInvcH SalPreInvcHSiNavigation { get; set; }
    }
}
