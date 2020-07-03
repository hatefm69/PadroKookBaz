using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsStsTypUsr
    {
        public int TrsStsTypSi { get; set; }
        public int TrsUsrGrpSi { get; set; }

        public virtual TrsStsTyp TrsStsTypSiNavigation { get; set; }
        public virtual TrsUsrGrp TrsUsrGrpSiNavigation { get; set; }
    }
}
