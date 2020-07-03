using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalCntrctGrp
    {
        public SalCntrctGrp()
        {
            SalCntrct = new HashSet<SalCntrct>();
        }

        public string SalCntrctGrpSi { get; set; }
        public string SalCntrctGrpTp { get; set; }

        public virtual ICollection<SalCntrct> SalCntrct { get; set; }
    }
}
