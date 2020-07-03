using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwInvDocDsrl
    {
        public int? InvDocHCu { get; set; }
        public string InvDocHDs { get; set; }
        public string InvDocDsrlSrl { get; set; }
        public string InvDocTypTp { get; set; }
        public int InvGdsSi { get; set; }
        public int InvDocHSi { get; set; }
        public int InvInvtSi { get; set; }
        public int InvDocTypSi { get; set; }
        public string InvDocDsrlDestroySts { get; set; }
        public bool? InvDocDsrlDestroy { get; set; }
    }
}
