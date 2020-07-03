using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsArqstSts
    {
        public TrsArqstSts()
        {
            TrsArqst = new HashSet<TrsArqst>();
        }

        public int TrsArqstStsSi { get; set; }
        public string TrsArqstStsTp { get; set; }

        public virtual ICollection<TrsArqst> TrsArqst { get; set; }
    }
}
