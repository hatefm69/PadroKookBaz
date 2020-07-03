using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PerLoanTyp
    {
        public PerLoanTyp()
        {
            PerLoans = new HashSet<PerLoans>();
        }

        public int PerLoanTypSi { get; set; }
        public string PerLoanTypCu { get; set; }
        public string PerLoanTypTp { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }

        public virtual ICollection<PerLoans> PerLoans { get; set; }
    }
}
