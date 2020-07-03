using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwTrsDcS
    {
        public int? TrsDcSSi { get; set; }
        public int TrsDcCSi { get; set; }
        public int TrsStsSi { get; set; }
        public DateTime? TrsDcSDt { get; set; }
        public string TrsStsTp { get; set; }
        public string TrsDcSTm { get; set; }
    }
}
