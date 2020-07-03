using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class حسابداري112گزارشدفترکل
    {
        public int? شمارهسند { get; set; }
        public string تاريخ { get; set; }
        public string کدکل { get; set; }
        public string نامکل { get; set; }
        public decimal? بدهکار { get; set; }
        public decimal? بستانکار { get; set; }
    }
}
