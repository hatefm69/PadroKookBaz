using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PurReqstD
    {
        public int PurReqstDSi { get; set; }
        public int PurReqstHSi { get; set; }
        public double? PurReqstDQty { get; set; }
        public string PurReqstDTp { get; set; }
        public int? InvGdsSi { get; set; }
        public int? PurReqstDUsage { get; set; }
        public string PurReqstDDt { get; set; }
        public int? PurOrderHSi { get; set; }
        public int? PurOrderDSi { get; set; }
        public double? PurReqstDFirstQty { get; set; }
        public int? PurchaseOrderDetailId { get; set; }

        public virtual PurReqstH PurReqstHSiNavigation { get; set; }
    }
}
