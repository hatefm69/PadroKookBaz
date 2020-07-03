using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalInvcAttach
    {
        public int SalInvcAttachSi { get; set; }
        public string SalInvcAttachDs { get; set; }
        public string SalInvcAttachTp { get; set; }
        public string SalInvcAttachFileName { get; set; }
        public byte[] SalInvcAttachFile { get; set; }
        public int? SalInvchSi { get; set; }

        public virtual SalInvcH SalInvchSiNavigation { get; set; }
    }
}
