using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalTaxD
    {
        public int SalTaxDSi { get; set; }
        public int? SalTaxHSi { get; set; }
        public decimal? SalTaxDFrom { get; set; }
        public decimal? SalTaxDTo { get; set; }
        public double? SalTaxDPersent { get; set; }

        public virtual SalTaxH SalTaxHSiNavigation { get; set; }
    }
}
