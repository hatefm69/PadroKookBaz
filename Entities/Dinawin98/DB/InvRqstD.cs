using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvRqstD
    {
        public int InvRqstDSi { get; set; }
        public int InvRqstHSi { get; set; }
        public double InvRqstDQty { get; set; }
        public string InvRqstDTp { get; set; }
        public int? InvGdsSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public int? PerPrsnlSi { get; set; }
        public byte? InvRqstStsSi { get; set; }
        public int? InvGdsTypSi { get; set; }
        public double? InvRqstDQtyAccept { get; set; }
        public double? InvRqstDQtyRemain { get; set; }

        public virtual InvRqstH InvRqstHSiNavigation { get; set; }
        public virtual InvRqstSts InvRqstStsSiNavigation { get; set; }
    }
}
