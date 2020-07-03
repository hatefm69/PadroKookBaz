using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalEnterduced
    {
        public SalEnterduced()
        {
            SalCust = new HashSet<SalCust>();
        }

        public int SalEnterducedSi { get; set; }
        public string SalEnterducedTp { get; set; }

        public virtual ICollection<SalCust> SalCust { get; set; }
    }
}
