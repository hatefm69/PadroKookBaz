using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PerPrsnlHstryTch
    {
        public int PerPrsnlHstryTchSi { get; set; }
        public string PerPrsnlHstryTchTyp { get; set; }
        public string PerPrsnlHstryTchTp { get; set; }
        public string PerPrsnlHstryTchPlc { get; set; }
        public string PerPrsnlHstryTchTime { get; set; }
        public DateTime? PerPrsnlHstryTchDateStr { get; set; }
        public DateTime? PerPrsnlHstryTchDateEnd { get; set; }
        public int? PerPrsnlSi { get; set; }
    }
}
