using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwInvDocAuto
    {
        public int InvInvtSiSource { get; set; }
        public int InvDocTypSiSource { get; set; }
        public int InvInvtSiDest { get; set; }
        public int InvDocTypSiDest { get; set; }
        public bool? InvDocAutoExpandBom { get; set; }
        public string InvInvtCuSource { get; set; }
        public string InvInvtTpSource { get; set; }
        public string InvDocTypTpSource { get; set; }
        public string InvInvtCuDest { get; set; }
        public string InvInvtTpDest { get; set; }
        public string InvDocTypTpDest { get; set; }
        public string InvDocTypTpSource2 { get; set; }
        public string InvDocTypTpDest2 { get; set; }
    }
}
