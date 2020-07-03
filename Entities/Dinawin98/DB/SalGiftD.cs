using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalGiftD
    {
        public int SalGiftDSi { get; set; }
        public int SalGiftHSi { get; set; }
        public int InvGdsSi { get; set; }
        public decimal? InvGdsQty { get; set; }
        public decimal? InvGdsTotal { get; set; }
        public int? InvUntSi { get; set; }

        public virtual SalGiftH SalGiftHSiNavigation { get; set; }
    }
}
