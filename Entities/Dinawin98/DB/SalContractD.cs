using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalContractD
    {
        public int SalContractDSi { get; set; }
        public int SalContractHSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double? SalContractQuantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? LineTotal { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual SalContractH SalContractHSiNavigation { get; set; }
    }
}
