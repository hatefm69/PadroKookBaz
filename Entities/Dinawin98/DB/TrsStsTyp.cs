using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsStsTyp
    {
        public TrsStsTyp()
        {
            TrsStsTypUsr = new HashSet<TrsStsTypUsr>();
        }

        public int TrsStsTypSi { get; set; }
        public string TrsStsTypTp { get; set; }

        public virtual ICollection<TrsStsTypUsr> TrsStsTypUsr { get; set; }
    }
}
