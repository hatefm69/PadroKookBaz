﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwSalCntrctGds
    {
        public int InvGdsSi { get; set; }
        public double SalCntrctGdsQty { get; set; }
        public decimal SalCntrctGdsUntPrc { get; set; }
        public decimal SalCntrctGdsPrc { get; set; }
        public string SalCntrctGdsI1 { get; set; }
        public string SalCntrctGdsI2 { get; set; }
        public string SalCntrctGdsI3 { get; set; }
        public string SalCntrctGdsD1 { get; set; }
        public string SalCntrctGdsD2 { get; set; }
        public string SalCntrctGdsD3 { get; set; }
        public string InvGdsTp { get; set; }
    }
}
