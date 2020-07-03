using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PerIncDec
    {
        public int PerIncDecSi { get; set; }
        public int PerPrsnlSi { get; set; }
        public string PerIncDecDs { get; set; }
        public string PerIncDecTp { get; set; }
        public decimal PerIncDecPrc { get; set; }

        public virtual PerPrsnl PerPrsnlSiNavigation { get; set; }
    }
}
