using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PerWrkLstAttach
    {
        public int PerWrkLstAttachSi { get; set; }
        public string PerWrkLstAttachDs { get; set; }
        public string PerWrkLstAttachTp { get; set; }
        public string PerWrkLstAttachFileName { get; set; }
        public byte[] PerWrkLstAttachFile { get; set; }
    }
}
