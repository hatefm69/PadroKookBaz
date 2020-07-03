using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvDocAuto
    {
        public int InvInvtSiSource { get; set; }
        public int InvDocTypSiSource { get; set; }
        public int InvInvtSiDest { get; set; }
        public int InvDocTypSiDest { get; set; }
        public bool? InvDocAutoExpandBom { get; set; }

        public virtual InvDocTyp InvDocTypSiDestNavigation { get; set; }
        public virtual InvDocTyp InvDocTypSiSourceNavigation { get; set; }
        public virtual InvInvt InvInvtSiDestNavigation { get; set; }
        public virtual InvInvt InvInvtSiSourceNavigation { get; set; }
    }
}
