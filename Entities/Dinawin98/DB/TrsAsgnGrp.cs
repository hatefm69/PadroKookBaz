using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsAsgnGrp
    {
        public TrsAsgnGrp()
        {
            TrsAsgn = new HashSet<TrsAsgn>();
            TrsAsgnGrpUsr = new HashSet<TrsAsgnGrpUsr>();
        }

        public string TrsAsgnGrpSi { get; set; }
        public string TrsAsgnGrpTp { get; set; }

        public virtual ICollection<TrsAsgn> TrsAsgn { get; set; }
        public virtual ICollection<TrsAsgnGrpUsr> TrsAsgnGrpUsr { get; set; }
    }
}
