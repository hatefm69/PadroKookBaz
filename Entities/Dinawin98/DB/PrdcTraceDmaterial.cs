﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PrdcTraceDmaterial
    {
        public int PrdcTraceDmaterialSi { get; set; }
        public int? PrdcTraceDinfoSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double? PrdcTraceDmaterialValue { get; set; }
        public int? PrdcWorkOrderDmaterialSi { get; set; }
        public int? PrdcTraceDmaterialInvDocType { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual PrdcTraceDinfo PrdcTraceDinfoSiNavigation { get; set; }
    }
}
