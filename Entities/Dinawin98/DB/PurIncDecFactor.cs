using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PurIncDecFactor
    {
        public int PurIncDecFactorSi { get; set; }
        public int PurIncDecFactorTypeSi { get; set; }
        public int PurBuyDSi { get; set; }
        public decimal PurIncDecFactorAmnt { get; set; }
        public double? PurIncDecFactorPerc { get; set; }
        public string PurIncDecFactorDesc { get; set; }

        public virtual PurBuyD PurBuyDSiNavigation { get; set; }
        public virtual PurIncDecFactorType PurIncDecFactorTypeSiNavigation { get; set; }
    }
}
