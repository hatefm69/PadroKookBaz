using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsDcGrp
    {
        public TrsDcGrp()
        {
            TrsDc = new HashSet<TrsDc>();
        }

        public int TrsDcGrpSi { get; set; }
        public string TrsDcGrpTp { get; set; }

        public virtual ICollection<TrsDc> TrsDc { get; set; }
    }
}
