using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalPreInvcSrvOpr
    {
        public int SalPreInvcSrvOprSi { get; set; }
        public int SalPreInvcSrvHSi { get; set; }
        public int SalOprSi { get; set; }
        public decimal SalPreInvcSrvOprValue { get; set; }
        public decimal SalPreInvcSrvOprCalcValue { get; set; }
        public int? AccMSi { get; set; }
        public int? AccTSi { get; set; }

        public virtual CtbAccM AccMSiNavigation { get; set; }
        public virtual CtbAccT AccTSiNavigation { get; set; }
        public virtual SalOpr SalOprSiNavigation { get; set; }
        public virtual SalPreInvcSrvH SalPreInvcSrvHSiNavigation { get; set; }
    }
}
