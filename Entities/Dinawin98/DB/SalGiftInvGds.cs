using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalGiftInvGds
    {
        public int SalGiftInvGdsSi { get; set; }
        public string SalGiftInvGdsCu { get; set; }
        public string SalGiftInvGdsTp { get; set; }
        public string SalGiftInvGdsQty { get; set; }
        public string SalGiftInvGdsTotal { get; set; }
        public int? InvGdsSi { get; set; }
        public int? InvUntSi { get; set; }
    }
}
