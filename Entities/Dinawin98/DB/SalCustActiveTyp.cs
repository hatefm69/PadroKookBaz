using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalCustActiveTyp
    {
        public SalCustActiveTyp()
        {
            SalCust = new HashSet<SalCust>();
        }

        public int SalCustActiveTypSi { get; set; }
        public string SalCustActiveTypTp { get; set; }

        public virtual ICollection<SalCust> SalCust { get; set; }
    }
}
