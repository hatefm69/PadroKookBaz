using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsDcAttach
    {
        public int TrsDcAttachSi { get; set; }
        public string TrsDcAttachDs { get; set; }
        public string TrsDcAttachTp { get; set; }
        public string TrsDcAttachFileName { get; set; }
        public byte[] TrsDcAttachFile { get; set; }
        public int? TrsDcSi { get; set; }

        public virtual TrsDc TrsDcSiNavigation { get; set; }
    }
}
