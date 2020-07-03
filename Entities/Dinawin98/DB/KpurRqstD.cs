using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class KpurRqstD
    {
        public int PurRqstDSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double? PurRqstDQty { get; set; }
        public DateTime? PurRqstDDt { get; set; }
        public int? PurRqstHSi { get; set; }
        public double? PurRqstDQtyInv { get; set; }
        public string PurRqstDDrftNo { get; set; }
        public DateTime? PurRqstDDrftDate { get; set; }
        public byte? PurRqstDPurKind { get; set; }
    }
}
