using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvUntCnvrt
    {
        public int InvUntSiFr { get; set; }
        public int InvUntSiTo { get; set; }
        public double? InvUntCnvrtCoefficient { get; set; }

        public virtual InvUnt InvUntSiFrNavigation { get; set; }
    }
}
