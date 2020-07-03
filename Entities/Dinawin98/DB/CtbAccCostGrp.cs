using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CtbAccCostGrp
    {
        public int SiCostGrp { get; set; }
        public string Cuacc { get; set; }
        public string Tpacc { get; set; }
        public int? SiFather { get; set; }
    }
}
