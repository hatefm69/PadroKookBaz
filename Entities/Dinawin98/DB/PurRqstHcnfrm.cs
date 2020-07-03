using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PurRqstHcnfrm
    {
        public PurRqstHcnfrm()
        {
            PurRqstH = new HashSet<PurRqstH>();
        }

        public byte PurRqstHcnfrmSi { get; set; }
        public string PurRqstHcnfrmTp { get; set; }

        public virtual ICollection<PurRqstH> PurRqstH { get; set; }
    }
}
