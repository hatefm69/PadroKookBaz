using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwAccCtbMinfo
    {
        public string AccCtbMinfoTp { get; set; }
        public string AccCtbMinfoValue { get; set; }
        public int? SiAccM { get; set; }
        public bool? IsInput { get; set; }
        public int? SiDdoc { get; set; }
        public int? AccCtbMinfoValueSi { get; set; }
        public int AccCtbMinfoSi { get; set; }
        public string CuAcc { get; set; }
        public string TpAcc { get; set; }
        public int? SiHdoc { get; set; }
        public DateTime? DsDoc { get; set; }
        public int? CuDoc { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
    }
}
