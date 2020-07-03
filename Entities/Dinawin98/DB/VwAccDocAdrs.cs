using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwAccDocAdrs
    {
        public int AccDocDSi { get; set; }
        public int? AccDocHCu { get; set; }
        public double? AccDocDRow { get; set; }
        public bool? AccDocHTempDoc { get; set; }
        public DateTime? AccDocHDs { get; set; }
    }
}
