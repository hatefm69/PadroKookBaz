using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CtbAccT2ctbAccM
    {
        public int SiAccT2accM { get; set; }
        public int SiAccT { get; set; }
        public int SiAccM { get; set; }

        public virtual CtbAccM SiAccMNavigation { get; set; }
        public virtual CtbAccT SiAccTNavigation { get; set; }
    }
}
