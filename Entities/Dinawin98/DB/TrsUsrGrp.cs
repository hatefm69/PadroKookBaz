﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsUsrGrp
    {
        public TrsUsrGrp()
        {
            TrsAsgnGrpUsr = new HashSet<TrsAsgnGrpUsr>();
            TrsRsrcUsr = new HashSet<TrsRsrcUsr>();
            TrsStsTypUsr = new HashSet<TrsStsTypUsr>();
            TrsUsrToGrp = new HashSet<TrsUsrToGrp>();
        }

        public int TrsUsrGrpSi { get; set; }
        public string TrsUsrGrpTp { get; set; }

        public virtual ICollection<TrsAsgnGrpUsr> TrsAsgnGrpUsr { get; set; }
        public virtual ICollection<TrsRsrcUsr> TrsRsrcUsr { get; set; }
        public virtual ICollection<TrsStsTypUsr> TrsStsTypUsr { get; set; }
        public virtual ICollection<TrsUsrToGrp> TrsUsrToGrp { get; set; }
    }
}
