using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvCdngD
    {
        public int InvCdngDSi { get; set; }
        public int InvCdngHSi { get; set; }
        public string InvCdngDCu { get; set; }
        public string InvCdngDTp { get; set; }
        public int? InvCdngDSqnc { get; set; }
        public string InvCdngDUid { get; set; }
        public string InvCdngDLnk { get; set; }

        public virtual InvCdngH InvCdngHSiNavigation { get; set; }
    }
}
