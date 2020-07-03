using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsChqP
    {
        public int TrsChqPSi { get; set; }
        public int AccLtSi { get; set; }
        public int TrsChqPBgnNo { get; set; }
        public int TrsChqPEndNo { get; set; }
        public DateTime? TrsChqPDt { get; set; }
        public bool? EndCheck { get; set; }

        public virtual CtbAccT AccLtSiNavigation { get; set; }
    }
}
