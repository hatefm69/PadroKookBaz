﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwAccBdgt
    {
        public int AccBudgetSi { get; set; }
        public string AccBudgetCu { get; set; }
        public string AccBudgetTp { get; set; }
        public DateTime? AccBudgetFromDs { get; set; }
        public DateTime? AccBudgetToDs { get; set; }
        public int? AccLkSi { get; set; }
        public int? SiAccM { get; set; }
        public int? SiAccT { get; set; }
        public int? SiProject { get; set; }
        public int? SiCost { get; set; }
        public double? AccBudgetPrc { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
        public string CuAccT { get; set; }
        public string TpAccT { get; set; }
        public string CuAcc { get; set; }
        public string TpAcc { get; set; }
        public string AccBudgetTypTp { get; set; }
        public string CuProject { get; set; }
        public string TpProject { get; set; }
        public string CuAccM { get; set; }
        public string TpAccM { get; set; }
        public int? SiFather { get; set; }
        public int? AccBudgetTypAcc { get; set; }
        public int? AccBudgetLevel { get; set; }
    }
}
