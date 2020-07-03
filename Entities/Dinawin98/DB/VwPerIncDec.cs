using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwPerIncDec
    {
        public int PerIncDecSi { get; set; }
        public int PerPrsnlSi { get; set; }
        public string PerIncDecDs { get; set; }
        public string PerIncDecTp { get; set; }
        public decimal PerIncDecPrc { get; set; }
        public string PerPrsnlCu { get; set; }
        public string PerPrsnlTp { get; set; }
    }
}
