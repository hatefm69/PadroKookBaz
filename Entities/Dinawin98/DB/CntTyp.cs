using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CntTyp
    {
        public CntTyp()
        {
            CntContract = new HashSet<CntContract>();
        }

        public int CntTypSi { get; set; }
        public string CntTypTx { get; set; }

        public virtual ICollection<CntContract> CntContract { get; set; }
    }
}
