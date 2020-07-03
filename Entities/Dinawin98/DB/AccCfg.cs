using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccCfg
    {
        public bool AccCfgReplication { get; set; }
        public int? AccLocSi { get; set; }
        public int? AccLocSiMain { get; set; }
        public bool? UnReplicate { get; set; }
    }
}
