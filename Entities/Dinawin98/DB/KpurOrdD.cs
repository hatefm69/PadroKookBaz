using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class KpurOrdD
    {
        public int PurOrdDSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double? PurOrdDQty { get; set; }
        public int? PurOrdHSi { get; set; }
        public double? PurOrdDPrc { get; set; }
        public int? PurRqstDSi { get; set; }

        public virtual KpurOrdrH PurOrdHSiNavigation { get; set; }
    }
}
