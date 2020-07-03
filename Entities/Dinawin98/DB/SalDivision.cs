using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalDivision
    {
        public SalDivision()
        {
            SalCust = new HashSet<SalCust>();
        }

        public int SalDivisionSi { get; set; }
        public string SalDivisionTp { get; set; }

        public virtual ICollection<SalCust> SalCust { get; set; }
    }
}
