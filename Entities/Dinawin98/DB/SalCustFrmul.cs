using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalCustFrmul
    {
        public int SalCustFrmulSi { get; set; }
        public int AccMSi { get; set; }
        public short SalCustFrmulOpr { get; set; }

        public virtual CtbAccM AccMSiNavigation { get; set; }
    }
}
