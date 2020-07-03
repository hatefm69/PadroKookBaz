using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwSalTresuryCust
    {
        public int? SalCustSi { get; set; }
        public string SalCustCu { get; set; }
        public string SalCustTp { get; set; }
        public decimal? TrsDcACreditC { get; set; }
        public decimal? SalInvcHPrcInc { get; set; }
        public decimal? SalInvcHPrcTotal { get; set; }
        public decimal? TrsDcADebitC { get; set; }
    }
}
