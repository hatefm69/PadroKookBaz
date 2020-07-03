using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PrdcBomd
    {
        public int PrdcBomdSi { get; set; }
        public int? PrdcBomSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double? PrdcBomdValue { get; set; }
        public double? PrdcBomdScrapValue { get; set; }
        public short? PrdcBomdStatus { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual PrdcBom PrdcBomSiNavigation { get; set; }
    }
}
