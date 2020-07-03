using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsDcTyp
    {
        public TrsDcTyp()
        {
            TrsDc = new HashSet<TrsDc>();
            TrsSts = new HashSet<TrsSts>();
        }

        public short TrsDcTypSi { get; set; }
        public string TrsDcTypTp { get; set; }
        public string TrsDcTypTp2 { get; set; }

        public virtual ICollection<TrsDc> TrsDc { get; set; }
        public virtual ICollection<TrsSts> TrsSts { get; set; }
    }
}
