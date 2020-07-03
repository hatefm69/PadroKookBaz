using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsRsrcUsr
    {
        public int TrsRsrcSi { get; set; }
        public int TrsUsrGrpSi { get; set; }

        public virtual TrsRsrc TrsRsrcSiNavigation { get; set; }
        public virtual TrsUsrGrp TrsUsrGrpSiNavigation { get; set; }
    }
}
