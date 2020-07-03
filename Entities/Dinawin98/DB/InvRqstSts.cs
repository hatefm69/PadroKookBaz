using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvRqstSts
    {
        public InvRqstSts()
        {
            InvRqstD = new HashSet<InvRqstD>();
        }

        public byte InvRqstStsSi { get; set; }
        public string InvRqstStsTp { get; set; }

        public virtual ICollection<InvRqstD> InvRqstD { get; set; }
    }
}
