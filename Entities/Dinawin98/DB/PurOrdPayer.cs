using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PurOrdPayer
    {
        public PurOrdPayer()
        {
            PurOrderH = new HashSet<PurOrderH>();
        }

        public int PurOrdPayerSi { get; set; }
        public string PurOrdPayerTp { get; set; }

        public virtual ICollection<PurOrderH> PurOrderH { get; set; }
    }
}
