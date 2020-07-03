using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwPurOrdVndrList
    {
        public int? PurOrderHCu { get; set; }
        public DateTime? PurOrderHDt { get; set; }
        public string PurOrderHTp { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public bool? PurOrderHOk { get; set; }
        public int? PurOrderHProcess { get; set; }
        public int? PurOrderHKindOrd { get; set; }
        public int PurOrdVndrSi { get; set; }
        public int? PurOrderHSi { get; set; }
        public int? PurReqstHSi { get; set; }
    }
}
