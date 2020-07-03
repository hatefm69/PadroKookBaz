using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwAccLt
    {
        public int AccLtSi { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public string AccLtTp2 { get; set; }
        public int SiFather { get; set; }
    }
}
