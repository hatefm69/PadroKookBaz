using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalPreInvcAttach
    {
        public int SalPreInvcAttachSi { get; set; }
        public string SalPreInvcAttachDs { get; set; }
        public string SalPreInvcAttachTp { get; set; }
        public string SalPreInvcAttachFileName { get; set; }
        public byte[] SalPreInvcAttachFile { get; set; }
        public int? SalPreInvchSi { get; set; }

        public virtual SalPreInvcH SalPreInvchSiNavigation { get; set; }
    }
}
