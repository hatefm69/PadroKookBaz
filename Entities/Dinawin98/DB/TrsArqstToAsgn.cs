﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsArqstToAsgn
    {
        public int TrsArqstToAsgnSi { get; set; }
        public int? TrsArqstSi { get; set; }
        public int? TrsAsgnSi { get; set; }
        public double? TrsArqstToAsgnPrc { get; set; }
        public int? SiAccT { get; set; }
        public int? SiCost { get; set; }
        public int? SiProject { get; set; }
        public string TrsArqstToAsgnTp { get; set; }

        public virtual TrsArqst TrsArqstSiNavigation { get; set; }
    }
}
