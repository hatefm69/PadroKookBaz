using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalDocPur
    {
        public int SalDocPurSi { get; set; }
        public int? SalInvcHSi { get; set; }
        public int AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string SalDocPurTp { get; set; }
        public decimal SalDocPurDebit { get; set; }
        public decimal SalDocPurCredit { get; set; }
    }
}
