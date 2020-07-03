using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsRsrcTyp
    {
        public TrsRsrcTyp()
        {
            TrsRsrc = new HashSet<TrsRsrc>();
        }

        public int TrsRsrcTypSi { get; set; }
        public string TrsRsrcTypTp { get; set; }

        public virtual ICollection<TrsRsrc> TrsRsrc { get; set; }
    }
}
