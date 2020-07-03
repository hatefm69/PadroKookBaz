using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwpurOrdVndr
    {
        public int? PurOrderHCu { get; set; }
        public DateTime? PurOrderHDt { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public int? PurVndrScore { get; set; }
        public byte? PurVndrSts { get; set; }
        public int PurOrdVndrSi { get; set; }
        public int? PurVndrSi { get; set; }
        public int? PurOrderHSi { get; set; }
    }
}
