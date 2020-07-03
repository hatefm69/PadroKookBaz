using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AssServiceD
    {
        public int AssSrvDSi { get; set; }
        public int AssSrvHSi { get; set; }
        public int? AssInvGdsSi { get; set; }
        public int? AssInvGdsQty1 { get; set; }
        public int? AssInvGdsQty2 { get; set; }
        public string AssInvGdsCu { get; set; }
        public string AssInvGdsTx { get; set; }

        public virtual AssInvGds AssInvGdsSiNavigation { get; set; }
        public virtual AssServiceH AssSrvHSiNavigation { get; set; }
    }
}
