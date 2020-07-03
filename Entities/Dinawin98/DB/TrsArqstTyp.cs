using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsArqstTyp
    {
        public TrsArqstTyp()
        {
            TrsArqst = new HashSet<TrsArqst>();
        }

        public int TrsArqstTypSi { get; set; }
        public string TrsArqstTypTp { get; set; }

        public virtual ICollection<TrsArqst> TrsArqst { get; set; }
    }
}
