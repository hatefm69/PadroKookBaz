using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class BgtChangeCostD
    {
        public int BgtChangeCostDSi { get; set; }
        public int BgtChangeCostHSi { get; set; }
        public int SiAccM { get; set; }
        public byte BgtChangeCostDAdjCoef { get; set; }
        public decimal BgtChangeCostDCost { get; set; }

        public virtual BgtChangeCostH BgtChangeCostHSiNavigation { get; set; }
        public virtual CtbAccM SiAccMNavigation { get; set; }
    }
}
