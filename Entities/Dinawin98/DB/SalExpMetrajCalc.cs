﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalExpMetrajCalc
    {
        public int SiId { get; set; }
        public double? Metraj { get; set; }
        public double? Taghe { get; set; }
        public int? SiH { get; set; }
        public int? SiD { get; set; }
        public bool? InsUpd { get; set; }
        public double? Sum { get; set; }
        public string Tp { get; set; }
        public int? InvGdsSi { get; set; }
    }
}
