using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsCfg
    {
        public bool? AcRsrc { get; set; }
        public bool? AcAsgn { get; set; }
        public bool? AcSts { get; set; }
        public bool AcAordr { get; set; }
        public bool? AcAcurncy { get; set; }
    }
}
