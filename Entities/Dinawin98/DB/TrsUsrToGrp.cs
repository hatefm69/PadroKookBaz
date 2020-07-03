using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsUsrToGrp
    {
        public int TrsUsrGrpSi { get; set; }
        public int TrsUsrSi { get; set; }

        public virtual TrsUsrGrp TrsUsrGrpSiNavigation { get; set; }
        public virtual TrsUsr TrsUsrSiNavigation { get; set; }
    }
}
