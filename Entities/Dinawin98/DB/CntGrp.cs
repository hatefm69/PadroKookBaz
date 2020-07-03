using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CntGrp
    {
        public CntGrp()
        {
            CntContract = new HashSet<CntContract>();
        }

        public int CntGrpSi { get; set; }
        public int? CntGrpSiParent { get; set; }
        public string CntGrpTx { get; set; }

        public virtual ICollection<CntContract> CntContract { get; set; }
    }
}
