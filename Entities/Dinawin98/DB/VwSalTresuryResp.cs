using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwSalTresuryResp
    {
        public decimal? TrsDcACreditC { get; set; }
        public string SalRespTp { get; set; }
        public int? SalRespSi { get; set; }
        public decimal? SalInvcHPrcInc { get; set; }
        public decimal? SalInvcHPrcTotal { get; set; }
        public decimal? TrsDcADebitC { get; set; }
    }
}
