using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalDocVchr
    {
        public int SalDocVchrSi { get; set; }
        public int? SalInvcHSi { get; set; }
        public int? SalRetInvcHSi { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string SalDocVchrTp { get; set; }
        public decimal SalDocVchrDebit { get; set; }
        public decimal SalDocVchrCredit { get; set; }
        public decimal? SalDocVchrDebitC { get; set; }
        public decimal? SalDocVchrCreditC { get; set; }

        public virtual SalInvcH SalInvcHSiNavigation { get; set; }
    }
}
