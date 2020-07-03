using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvGdsRepGds
    {
        public int InvGdsRepGdsSi { get; set; }
        public int? InvGdsMSi { get; set; }
        public int? InvGdsDSi { get; set; }

        public virtual InvGds InvGdsMSiNavigation { get; set; }
    }
}
