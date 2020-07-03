using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalRetInvcDsrl
    {
        public int SalRetInvcHSi { get; set; }
        public int InvGdsSi { get; set; }
        public string SalRetInvcDsrlSrl { get; set; }
        public bool? SalRetInvcDsrlDestroy { get; set; }
        public int? SalInvcHSi { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual SalRetInvcH SalRetInvcHSiNavigation { get; set; }
    }
}
