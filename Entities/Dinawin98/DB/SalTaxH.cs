using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalTaxH
    {
        public SalTaxH()
        {
            SalTaxD = new HashSet<SalTaxD>();
        }

        public int SalTaxHSi { get; set; }
        public string SalTaxHDs { get; set; }
        public string SalTaxHTp { get; set; }
        public bool? SalTaxHAct { get; set; }

        public virtual ICollection<SalTaxD> SalTaxD { get; set; }
    }
}
