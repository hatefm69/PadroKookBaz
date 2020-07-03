using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvCntrDocD
    {
        public int InvCntrDocDSi { get; set; }
        public int? InvCntrDocHSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double? InvCntrDocDQty { get; set; }
        public int? InvUntSi { get; set; }
        public string InvCntrDocDTp { get; set; }
        public int? InvGdsTypSi { get; set; }

        public virtual InvCntrDocH InvCntrDocHSiNavigation { get; set; }
    }
}
