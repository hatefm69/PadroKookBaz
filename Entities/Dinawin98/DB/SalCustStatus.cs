using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalCustStatus
    {
        public SalCustStatus()
        {
            SalCust = new HashSet<SalCust>();
        }

        public int SalCustStatusSi { get; set; }
        public string SalCustStatusTp { get; set; }

        public virtual ICollection<SalCust> SalCust { get; set; }
    }
}
