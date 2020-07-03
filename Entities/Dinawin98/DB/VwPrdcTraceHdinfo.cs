using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwPrdcTraceHdinfo
    {
        public int PrdcTraceHSi { get; set; }
        public int? PrdcWorkOrderHSi { get; set; }
        public string PrdcTraceHDate { get; set; }
        public string PrdcTraceHCu { get; set; }
        public int? InvInvtSi { get; set; }
        public string PrdcTraceHDescription { get; set; }
        public bool? PrdcTraceHLock { get; set; }
        public bool? PrdcTraceHSendDoc { get; set; }
        public int? InvGdsSi { get; set; }
        public double? PrdcTraceDinfoQuantity { get; set; }
        public int? PrdcTraceDinfoSi { get; set; }
        public int? PrdcBomSi { get; set; }
        public int? PrdcLineTitleSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string PrdcBomFormula { get; set; }
        public string PrdcLineTitleTp { get; set; }
    }
}
