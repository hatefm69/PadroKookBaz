using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvDocDsts
    {
        public InvDocDsts()
        {
            InvDocD = new HashSet<InvDocD>();
        }

        public byte InvDocDstsSi { get; set; }
        public string InvDocDstsTp { get; set; }

        public virtual ICollection<InvDocD> InvDocD { get; set; }
    }
}
