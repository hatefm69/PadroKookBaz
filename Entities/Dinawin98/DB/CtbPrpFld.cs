using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CtbPrpFld
    {
        public CtbPrpFld()
        {
            CtbPrpVlu = new HashSet<CtbPrpVlu>();
        }

        public int CtbPrpFldSi { get; set; }
        public int CtbPrpGrpSi { get; set; }
        public string CtbPrpFldCu { get; set; }
        public string CtbPrpFldTp { get; set; }
        public int? CtbPrpFldClr { get; set; }
        public int? CtbPrpFldSqnc { get; set; }

        public virtual ICollection<CtbPrpVlu> CtbPrpVlu { get; set; }
    }
}
