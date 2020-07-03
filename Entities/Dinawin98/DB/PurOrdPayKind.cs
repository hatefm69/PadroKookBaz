using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PurOrdPayKind
    {
        public PurOrdPayKind()
        {
            PurOrderH = new HashSet<PurOrderH>();
        }

        public int PurOrdPayKindSi { get; set; }
        public string PurOrdPayKindTp { get; set; }

        public virtual ICollection<PurOrderH> PurOrderH { get; set; }
    }
}
