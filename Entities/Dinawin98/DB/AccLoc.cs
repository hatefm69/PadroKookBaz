using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccLoc
    {
        public AccLoc()
        {
            AccHdoc = new HashSet<AccHdoc>();
        }

        public int AccLocSi { get; set; }
        public string AccLocTp { get; set; }

        public virtual ICollection<AccHdoc> AccHdoc { get; set; }
    }
}
