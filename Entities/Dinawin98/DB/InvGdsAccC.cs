using Entities;
using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public class InvGdsAccC : BaseEntity
    {
        public int InvGdsSi { get; set; }
        public int AccLcSi { get; set; }
        public int AccLmSi { get; set; }
        public int? AccLtSi { get; set; }

        public virtual CtbCost AccLcSiNavigation { get; set; }
        public virtual CtbAccM AccLmSiNavigation { get; set; }
        public virtual CtbAccT AccLtSiNavigation { get; set; }
        public virtual InvGds InvGdsSiNavigation { get; set; }
    }
}
