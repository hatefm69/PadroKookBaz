using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalCntrctSts
    {
        public SalCntrctSts()
        {
            SalCntrct = new HashSet<SalCntrct>();
        }

        public byte SalCntrctStsSi { get; set; }
        public string SalCntrctStsTp { get; set; }

        public virtual ICollection<SalCntrct> SalCntrct { get; set; }
    }
}
