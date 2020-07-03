using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalSrvAcc
    {
        public int SalSrvAccSi { get; set; }
        public int? SalSrvSi { get; set; }
        public int? SalSrvAccAccMSi { get; set; }
        public int? SalSrvAccAccTSi { get; set; }

        public virtual CtbAccM SalSrvAccAccMSiNavigation { get; set; }
        public virtual CtbAccT SalSrvAccAccTSiNavigation { get; set; }
        public virtual SalSrv SalSrvSiNavigation { get; set; }
    }
}
