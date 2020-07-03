using Entities;
using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public class SalGdsAcc : BaseEntity
    {
        public int SalGdsAccSi { get; set; }
        public int InvGdsSi { get; set; }
        public int SalGdsAccAccMSi { get; set; }
        public int? SalGdsAccAccTSi { get; set; }
        public int? SalGdsAccAccCSi { get; set; }
        public int? SalGdsAccAccPSi { get; set; }
        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual CtbAccM SalGdsAccAccMSiNavigation { get; set; }
        public virtual CtbAccT SalGdsAccAccTSiNavigation { get; set; }
    }
}
