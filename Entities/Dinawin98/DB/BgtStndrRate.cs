using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class BgtStndrRate
    {
        public int BgtStndrRateSi { get; set; }
        public int InvGdsSi { get; set; }
        public int InvUntSi { get; set; }
        public byte BgtStndrRateCoef { get; set; }
        public decimal BgtStndrRatePrice { get; set; }
    }
}
