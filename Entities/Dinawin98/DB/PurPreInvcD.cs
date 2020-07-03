using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PurPreInvcD
    {
        public int PurPreInvcDSi { get; set; }
        public int? PurPreInvcHSi { get; set; }
        public int? PurOrderDSi { get; set; }
        public double? PurPreInvcDQty { get; set; }
        public decimal? PurPreInvcDPrice { get; set; }
        public string PurPreInvcDDesc { get; set; }

        public virtual PurPreInvcH PurPreInvcHSiNavigation { get; set; }
    }
}
