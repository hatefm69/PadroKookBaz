﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwPrdcTraceH
    {
        public int PrdcTraceHSi { get; set; }
        public int? PrdcWorkOrderHSi { get; set; }
        public string PrdcTraceHDate { get; set; }
        public string PrdcTraceHCu { get; set; }
        public int? InvInvtSi { get; set; }
        public string PrdcTraceHDescription { get; set; }
        public bool? PrdcTraceHLock { get; set; }
        public bool? PrdcTraceHSendDoc { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
    }
}
