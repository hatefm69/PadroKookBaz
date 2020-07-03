using Entities;
using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public class InvGdsAccP : BaseEntity
    {
        public int InvGdsSi { get; set; }
        public int AccLpSi { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }

        public virtual CtbAccM AccLmSiNavigation { get; set; }
        public virtual CtbProject AccLpSiNavigation { get; set; }
        public virtual CtbAccT AccLtSiNavigation { get; set; }
        public virtual InvGds InvGdsSiNavigation { get; set; }
    }
}