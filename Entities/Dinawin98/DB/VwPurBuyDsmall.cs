using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwPurBuyDsmall
    {
        public int? PurBuyHSi { get; set; }
        public double? PurBuyDPrice { get; set; }
        public double? PurBuyDQty { get; set; }
        public int PurBuyDSi { get; set; }
        public int PurOrderDSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvUntTp { get; set; }
        public double? PurReqstDQty { get; set; }
        public string PurReqstDDt { get; set; }
        public int? PurReqstHCu { get; set; }
        public int? PurOrderHCu { get; set; }
        public DateTime? PurOrderHDt { get; set; }
    }
}
