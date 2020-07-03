using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PurEnqry
    {
        public int PurEnqrySi { get; set; }
        public int PurVndrSi { get; set; }
        public int InvGdsSi { get; set; }
        public int PurRespSi { get; set; }
        public DateTime? PurEnqryDt { get; set; }
        public decimal? PurEnqryUntPrc { get; set; }
        public string PurEnqryTp { get; set; }
        public int? PurOrdrSi { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual PurOrdr PurOrdrSiNavigation { get; set; }
        public virtual PurVndr PurVndrSiNavigation { get; set; }
    }
}
