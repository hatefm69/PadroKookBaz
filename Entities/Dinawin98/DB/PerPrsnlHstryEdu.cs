using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PerPrsnlHstryEdu
    {
        public int PerPrsnlHstryEduSi { get; set; }
        public string PerPrsnlHstryEduBrnch { get; set; }
        public string PerPrsnlHstryEduMadrak { get; set; }
        public string PerPrsnlHstryEduEduPlc { get; set; }
        public string PerPrsnlHstryEduAvg { get; set; }
        public DateTime? PerPrsnlHstryEduDateStr { get; set; }
        public DateTime? PerPrsnlHstryEduDateEnd { get; set; }
        public int? PerPrsnlSi { get; set; }
    }
}
