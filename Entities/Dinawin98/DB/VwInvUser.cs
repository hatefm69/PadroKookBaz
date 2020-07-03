using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwInvUser
    {
        public string InvUsrLgnName { get; set; }
        public int? InvInvtSi { get; set; }
        public bool? InvUsrAcsMny { get; set; }
        public bool? InvUsrAcsQty { get; set; }
        public string InvUsrTp { get; set; }
    }
}
