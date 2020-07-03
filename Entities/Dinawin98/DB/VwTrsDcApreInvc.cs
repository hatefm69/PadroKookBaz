using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwTrsDcApreInvc
    {
        public int TrsDcApreInvcSi { get; set; }
        public int TrsDcASi { get; set; }
        public int SalPreInvcHSi { get; set; }
        public int? SalPreInvcHCu { get; set; }
        public string SalPreInvcHDs { get; set; }
        public decimal SalPreInvcHPrcTotal { get; set; }
        public int SalCustSi { get; set; }
        public string SalCustTp { get; set; }
        public decimal? SalPreInvcHPrcSumTotalC { get; set; }
        public double? SalPreInvcHPrcSumQty { get; set; }
    }
}
