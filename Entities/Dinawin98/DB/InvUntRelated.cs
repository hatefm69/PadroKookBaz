using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvUntRelated
    {
        public int InvUntSi { get; set; }
        public int InvUntSiParent { get; set; }

        public virtual InvUnt InvUntSiParentNavigation { get; set; }
    }
}
