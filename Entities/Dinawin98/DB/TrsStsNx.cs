using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsStsNx
    {
        public short TrsDcTypSi { get; set; }
        public short TrsCtypSi { get; set; }
        public short TrsStsSi { get; set; }
        public short TrsStsSiNx { get; set; }

        public virtual TrsSts Trs { get; set; }
        public virtual TrsSts TrsNavigation { get; set; }
    }
}
