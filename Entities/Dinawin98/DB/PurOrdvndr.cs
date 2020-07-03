using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PurOrdvndr
    {
        public int PurOrdVndrSi { get; set; }
        public int? PurVndrSi { get; set; }
        public int? PurOrderHSi { get; set; }

        public virtual PurOrderH PurOrderHSiNavigation { get; set; }
    }
}
