using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PerPrsnlHstryWrk
    {
        public int PerPrsnlHstrywrkSi { get; set; }
        public string PerPrsnlHstrywrkTp { get; set; }
        public string PerPrsnlHstrywrkJob { get; set; }
        public string PerPrsnlHstrywrkRelated { get; set; }
        public DateTime? PerPrsnlHstrywrkDateStr { get; set; }
        public DateTime? PerPrsnlHstrywrkDateEnd { get; set; }
        public string PerPrsnlHstrywrkResaonEnd { get; set; }
        public string PerPrsnlHstrywrkDay { get; set; }
        public string PerPrsnlHstrywrkTel { get; set; }
        public string PerPrsnlHstrywrkEdu { get; set; }
        public string PerPrsnlHstrywrkResoanGo { get; set; }
        public int? PerPrsnlSi { get; set; }
    }
}
