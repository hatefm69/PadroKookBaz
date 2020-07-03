using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwSalTreasury
    {
        public int? SalInvcHCu { get; set; }
        public string SalInvcHDs { get; set; }
        public string SalCustTp { get; set; }
        public string SalRespTp { get; set; }
        public decimal? SalInvcHPrcTotal { get; set; }
        public double? SalInvcHPrcInc { get; set; }
        public decimal? TrsDcACreditC { get; set; }
        public decimal? TrsDcADebitC { get; set; }
        public int? SalRespSi { get; set; }
    }
}
