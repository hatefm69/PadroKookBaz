using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalInvcDsrl
    {
        public int SalInvcHSi { get; set; }
        public int InvGdsSi { get; set; }
        public string SalInvcDsrlSrl { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual SalInvcH SalInvcHSiNavigation { get; set; }
    }
}
