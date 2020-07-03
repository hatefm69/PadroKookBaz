using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsDcCattach
    {
        public int TrsDcCattachSi { get; set; }
        public string TrsDcCattachDs { get; set; }
        public string TrsDcCattachTp { get; set; }
        public string TrsDcCattachFileName { get; set; }
        public byte[] TrsDcCattachFile { get; set; }
        public int? TrsDcCSi { get; set; }
    }
}
