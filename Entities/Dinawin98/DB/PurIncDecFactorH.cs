using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PurIncDecFactorH
    {
        public int PurIncDecFactorHSi { get; set; }
        public int PurIncDecFactorTypeSi { get; set; }
        public int PurBuyHSi { get; set; }
        public decimal PurIncDecFactorHAmnt { get; set; }
        public double? PurIncDecFactorHPerc { get; set; }
        public string PurIncDecFactorHDesc { get; set; }

        public virtual PurBuyH PurBuyHSiNavigation { get; set; }
        public virtual PurIncDecFactorType PurIncDecFactorTypeSiNavigation { get; set; }
    }
}
