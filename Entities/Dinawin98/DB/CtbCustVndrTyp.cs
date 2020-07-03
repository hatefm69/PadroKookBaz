using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CtbCustVndrTyp
    {
        public CtbCustVndrTyp()
        {
            SalCust = new HashSet<SalCust>();
        }

        public int CtbCustVndrTypSi { get; set; }
        public string CtbCustVndrTypTp { get; set; }

        public virtual ICollection<SalCust> SalCust { get; set; }
    }
}
