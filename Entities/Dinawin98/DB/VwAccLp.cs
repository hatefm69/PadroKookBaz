using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwAccLp
    {
        public int AccLpSi { get; set; }
        public string AccLpCu { get; set; }
        public string AccLpTp { get; set; }
        public string AccLpTp2 { get; set; }
        public int? SiFather { get; set; }
    }
}
