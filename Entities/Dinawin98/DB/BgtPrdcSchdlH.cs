using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class BgtPrdcSchdlH
    {
        public int BgtPrdcSchdlHSi { get; set; }
        public string BgtPrdcSchdHYear { get; set; }
        public int? ProductId { get; set; }
        public int? BgtPrdcSchdlHTotalQty { get; set; }
    }
}
