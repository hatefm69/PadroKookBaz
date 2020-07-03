﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PurRqstD
    {
        public int PurRqstHSi { get; set; }
        public int InvGdsSi { get; set; }
        public double PurRqstDRqty { get; set; }
        public int? PurEnqrySi { get; set; }
        public int? PurOrdrSi { get; set; }
        public string InvDocHCu { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual PurOrdr PurOrdrSiNavigation { get; set; }
        public virtual PurRqstH PurRqstHSiNavigation { get; set; }
    }
}
