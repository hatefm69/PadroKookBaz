using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PerTaxD
    {
        public int PerTaxDSi { get; set; }
        public int PerTaxHSi { get; set; }
        public decimal PerTaxDSalaryMonth { get; set; }
        public decimal PerTaxDSalaryYear { get; set; }
        public double PerTaxDPersent { get; set; }
        public decimal PerTaxDPrice { get; set; }

        public virtual PerTaxH PerTaxHSiNavigation { get; set; }
    }
}
