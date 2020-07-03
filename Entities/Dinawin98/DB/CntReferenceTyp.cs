using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CntReferenceTyp
    {
        public CntReferenceTyp()
        {
            CntReference = new HashSet<CntReference>();
        }

        public int CntReferenceTypSi { get; set; }
        public string CntReferenceTypTx { get; set; }

        public virtual ICollection<CntReference> CntReference { get; set; }
    }
}
