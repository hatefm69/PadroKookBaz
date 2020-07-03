using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalContractTyp
    {
        public SalContractTyp()
        {
            SalContractH = new HashSet<SalContractH>();
        }

        public int SalCntrctTypeSi { get; set; }
        public int SalCntrctTypeCu { get; set; }
        public string SalCntrctTypeTp { get; set; }
        public bool? Status { get; set; }
        public int? SalCntrctTypeSiParent { get; set; }

        public virtual ICollection<SalContractH> SalContractH { get; set; }
    }
}
