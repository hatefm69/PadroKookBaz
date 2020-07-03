using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvCdngH
    {
        public InvCdngH()
        {
            InvCdngD = new HashSet<InvCdngD>();
        }

        public int InvCdngHSi { get; set; }
        public string InvCdngHTp { get; set; }
        public int? InvCdngHSqnc { get; set; }
        public int? InvCdngHTpSqnc { get; set; }
        public bool? InvCdngHVsTp { get; set; }
        public bool? InvCdngHVsCu { get; set; }

        public virtual ICollection<InvCdngD> InvCdngD { get; set; }
    }
}
