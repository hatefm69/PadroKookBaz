using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PerInsrnPromise
    {
        public int PerInsrnPromiseSi { get; set; }
        public string PerInsrnpromiseCu { get; set; }
        public string PerInsrnpromiseTp { get; set; }
        public int? PerInsrncGrpSi { get; set; }
    }
}
