using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccBudgetDetail
    {
        public int AccBudgetDetailSi { get; set; }
        public int? AccBudgetSi { get; set; }
        public double? AccBudgetDetailPrc { get; set; }
        public int? AccLkSi { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public int? SiFather { get; set; }
        public string AccBudgetDetailDesc { get; set; }
    }
}
