﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwPrdcTraceHdinfoMaterial
    {
        public int? InvGdsSiM { get; set; }
        public int? PrdcTraceDmaterialSi { get; set; }
        public int? PrdcTraceDinfoSi { get; set; }
        public double? PrdcTraceDmaterialValue { get; set; }
        public int? InvInvtSi { get; set; }
        public double? PrdcTraceDinfoQuantity { get; set; }
        public bool? PrdcTraceHLock { get; set; }
        public int? InvGdsSiI { get; set; }
        public int? PrdcWorkOrderHSi { get; set; }
    }
}
