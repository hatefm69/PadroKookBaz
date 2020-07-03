using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwSalIntrmdUser
    {
        public int SalIntrmdSi { get; set; }
        public string SalIntrmdCu { get; set; }
        public string SalIntrmdTp { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
    }
}
