using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwInvSrl
    {
        public string InvDocDsrlSrl { get; set; }
        public int InvGdsSi { get; set; }
        public int? InvInvtSi { get; set; }
        public int? InputCountSrl { get; set; }
        public int? OutPutCountSrl { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
        public int? InvDocTypSi { get; set; }
        public string InvDocTypTp { get; set; }
        public int? RemainSrl { get; set; }
    }
}
