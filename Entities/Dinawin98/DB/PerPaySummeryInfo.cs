using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PerPaySummeryInfo
    {
        public int PerPaySummeryInfoSi { get; set; }
        public string PerPaySummerySum1Now { get; set; }
        public string PerPaySummerySum2Now { get; set; }
        public string PerPaySummerySum1Pre { get; set; }
        public string PerPaySummerySum2Pre { get; set; }
        public string PerPaySummerySumTaxNow { get; set; }
        public string PerPaySummerySumTaxPre { get; set; }
    }
}
