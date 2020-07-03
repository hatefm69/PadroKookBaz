﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwPurenqueryOrdBuySelect
    {
        public decimal? PurPreInvcDPrice { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvUntTp { get; set; }
        public double? PurReqstDQty { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public int? PurOrderHCu { get; set; }
        public DateTime? PurOrderHDt { get; set; }
        public int PurOrderHSi { get; set; }
        public int? PurPreInvcDSi { get; set; }
        public int PurOrderDSi { get; set; }
        public bool? PurPreInvcHAccept { get; set; }
        public int? PurReqstHSi { get; set; }
    }
}
