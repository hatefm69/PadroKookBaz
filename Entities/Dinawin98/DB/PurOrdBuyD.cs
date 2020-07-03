using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PurOrdBuyD
    {
        public int PurOrdBuyDSi { get; set; }
        public int? PurOrderHSi { get; set; }
        public int? PurPreInvcDSi { get; set; }
        public int? PurOrdBuyHSi { get; set; }
        public int? PurOrderDSi { get; set; }
        public int? PurBuyDSi { get; set; }

        public virtual PurOrdBuyH PurOrdBuyHSiNavigation { get; set; }
    }
}
