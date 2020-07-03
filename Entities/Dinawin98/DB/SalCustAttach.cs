using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalCustAttach
    {
        public int SalCustAttachSi { get; set; }
        public string SalCustAttachDs { get; set; }
        public string SalCustAttachTp { get; set; }
        public string SalCustAttachFileName { get; set; }
        public byte[] SalCustAttachFile { get; set; }
        public int? SalCustSi { get; set; }
    }
}
