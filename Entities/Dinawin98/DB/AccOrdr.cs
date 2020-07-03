﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccOrdr
    {
        public int AccOrdrSi { get; set; }
        public DateTime AccOrdrDt { get; set; }
        public int? AccOrdrTypSi { get; set; }
        public decimal? AccOrdrPrc { get; set; }
        public string AccOrdrDesc { get; set; }
        public int? AccRqstSi { get; set; }
        public string StmpCus { get; set; }
        public DateTime? StmpCdt { get; set; }
        public string StmpMus { get; set; }
        public DateTime? StmpMdt { get; set; }
    }
}
