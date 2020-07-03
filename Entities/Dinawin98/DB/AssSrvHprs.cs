using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AssSrvHprs
    {
        public int AssSrvHprsSi { get; set; }
        public int? AssSrvHSi { get; set; }
        public int? AssPrsSi { get; set; }

        public virtual AssPersonel AssPrsSiNavigation { get; set; }
    }
}
