using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsAcc
    {
        public int AccLmSi { get; set; }
        public int AccLtSi { get; set; }
        public int AccLcSi { get; set; }
        public int AccLpSi { get; set; }
        public decimal TrsAccDebitMin { get; set; }
        public decimal TrsAccDebitMax { get; set; }
        public decimal TrsAccCreditMin { get; set; }
        public decimal TrsAccCreditMax { get; set; }

        public virtual CtbCost AccLcSiNavigation { get; set; }
        public virtual CtbAccM AccLmSiNavigation { get; set; }
        public virtual CtbProject AccLpSiNavigation { get; set; }
        public virtual CtbAccT AccLtSiNavigation { get; set; }
    }
}
