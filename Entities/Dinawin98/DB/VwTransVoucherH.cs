using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwTransVoucherH
    {
        public string TpHdoc { get; set; }
        public int? CuDoc { get; set; }
        public int? SiHdoc { get; set; }
        public string TransVoucherHTx { get; set; }
        public bool? TransVoucherHSent { get; set; }
        public DateTime? TransVoucherHDate { get; set; }
        public int TransVoucherHSi { get; set; }
    }
}
