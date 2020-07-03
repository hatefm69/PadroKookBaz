using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PurKind
    {
        public int PurKindSi { get; set; }
        public string PurKindCu { get; set; }
        public string PurKindTp { get; set; }
        public int? PurKindSiParent { get; set; }
    }
}
