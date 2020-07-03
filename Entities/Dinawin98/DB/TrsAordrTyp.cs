using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsAordrTyp
    {
        public TrsAordrTyp()
        {
            TrsAordr = new HashSet<TrsAordr>();
        }

        public int TrsAordrTypSi { get; set; }
        public string TrsAordrTypTp { get; set; }

        public virtual ICollection<TrsAordr> TrsAordr { get; set; }
    }
}
