using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CntAttachTyp
    {
        public CntAttachTyp()
        {
            CntAttachment = new HashSet<CntAttachment>();
        }

        public int CntAttachTypSi { get; set; }
        public string CntAttachTypTx { get; set; }

        public virtual ICollection<CntAttachment> CntAttachment { get; set; }
    }
}
