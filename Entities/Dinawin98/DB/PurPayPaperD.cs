using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PurPayPaperD
    {
        public int PurPayPaperDSi { get; set; }
        public int? PurPayPaperHSi { get; set; }
        public int? PurReqstHSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double? PurPayPaperDQty { get; set; }
        public double? PurPayPaperDPrice { get; set; }
        public double? PurPayPaperDTotal { get; set; }
    }
}
