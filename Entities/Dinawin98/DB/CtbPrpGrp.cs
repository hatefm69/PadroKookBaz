using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CtbPrpGrp
    {
        public CtbPrpGrp()
        {
            CtbPrpVlu = new HashSet<CtbPrpVlu>();
        }

        public int CtbPrpGrpSi { get; set; }
        public string CtbPrpGrpTp { get; set; }

        public virtual ICollection<CtbPrpVlu> CtbPrpVlu { get; set; }
    }
}
