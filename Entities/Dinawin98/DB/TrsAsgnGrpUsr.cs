using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsAsgnGrpUsr
    {
        public string TrsAsgnGrpSi { get; set; }
        public int TrsUsrGrpSi { get; set; }

        public virtual TrsAsgnGrp TrsAsgnGrpSiNavigation { get; set; }
        public virtual TrsUsrGrp TrsUsrGrpSiNavigation { get; set; }
    }
}
