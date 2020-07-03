using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalAdjustment
    {
        public int SalAdjustmentSi { get; set; }
        public int? SiAccM { get; set; }
        public int? SalAdjustmentCu { get; set; }
        public string SalAdjustmentTp { get; set; }
    }
}
