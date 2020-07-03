using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwTrsDcAinvc
    {
        public int TrsDcAinvcSi { get; set; }
        public int TrsDcASi { get; set; }
        public int SalInvcHSi { get; set; }
        public int? SalInvcHCu { get; set; }
        public string SalInvcHDs { get; set; }
        public decimal SalInvcHPrcTotal { get; set; }
        public int SalCustSi { get; set; }
        public string SalCustTp { get; set; }
        public decimal? SalInvcHPrcSumTotalC { get; set; }
    }
}
