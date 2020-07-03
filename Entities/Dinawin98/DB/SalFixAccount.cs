using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalFixAccount
    {
        public int SalFixAccountSi { get; set; }
        public int? SiAccM { get; set; }
        public int? SalFixAccountCu { get; set; }
        public string SalFixAccountTp { get; set; }
    }
}
