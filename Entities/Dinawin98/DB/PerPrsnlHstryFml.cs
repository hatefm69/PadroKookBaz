using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PerPrsnlHstryFml
    {
        public int PerPrsnlHstryFmlSi { get; set; }
        public string PerPrsnlHstryFmlTp { get; set; }
        public string PerPrsnlHstryFmlTyp { get; set; }
        public DateTime? PerPrsnlHstryFmlDateBrth { get; set; }
        public string PerPrsnlHstryFmlMadrak { get; set; }
        public int? PerPrsnlSi { get; set; }
    }
}
