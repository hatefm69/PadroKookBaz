using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class KpurBuyH
    {
        public int PurBuyHSi { get; set; }
        public string PurBuyHCu { get; set; }
        public string PurBuyHCm { get; set; }
        public DateTime? PurBuyHDt { get; set; }
        public string PurBuyHVnFno { get; set; }
        public DateTime? PurBuyHFaDt { get; set; }
        public int? PurOrdrHSi { get; set; }
    }
}
