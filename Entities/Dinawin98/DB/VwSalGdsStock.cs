﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwSalGdsStock
    {
        public int GdsSi { get; set; }
        public double QrAll { get; set; }
        public double QvAll { get; set; }
        public int Invsi { get; set; }
        public string InvCu { get; set; }
        public string InvTp { get; set; }
        public double QrI { get; set; }
        public double QvI { get; set; }
        public double? Qsale { get; set; }
    }
}
