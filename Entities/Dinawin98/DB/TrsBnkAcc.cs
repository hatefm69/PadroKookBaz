using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsBnkAcc
    {
        public int TrsBnkAccSi { get; set; }
        public int? TrsRsrcSi { get; set; }
        public int? SiAccM { get; set; }
        public double? TrsBnkAccPrc { get; set; }
        public double? TrsBnkAccPrcAcc { get; set; }
    }
}
