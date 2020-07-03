using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CtbPrpVlu
    {
        public int CtbPrpVluSi { get; set; }
        public int CtbPrpGrpSi { get; set; }
        public int CtbPrpVluRfrncSi { get; set; }
        public int CtbPrpFldSi { get; set; }
        public string CtbPrpVluValue { get; set; }

        public virtual CtbPrpFld CtbPrpFldSiNavigation { get; set; }
        public virtual CtbPrpGrp CtbPrpGrpSiNavigation { get; set; }
    }
}
