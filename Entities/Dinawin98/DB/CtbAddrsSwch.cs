using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CtbAddrsSwch
    {
        public int CtbAddrsSwchSi { get; set; }
        public int CtbAddrsSi { get; set; }
        public string CtbAddrsSwchTbl { get; set; }
        public int CtbAddrsSwchTblSi { get; set; }
        public bool? CtbAddrsSwchActive { get; set; }

        public virtual CtbAddrs CtbAddrsSiNavigation { get; set; }
    }
}
