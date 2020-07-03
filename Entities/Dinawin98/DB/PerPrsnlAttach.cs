using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PerPrsnlAttach
    {
        public int PerPrsnlAttachSi { get; set; }
        public string PerPrsnlAttachDs { get; set; }
        public string PerPrsnlAttachTp { get; set; }
        public string PerPrsnlAttachFileName { get; set; }
        public byte[] PerPrsnlAttachFile { get; set; }
        public int? PerPrsnlSi { get; set; }

        public virtual PerPrsnl PerPrsnlSiNavigation { get; set; }
    }
}
