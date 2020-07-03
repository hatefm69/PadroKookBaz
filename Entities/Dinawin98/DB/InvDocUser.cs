using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvDocUser
    {
        public int InvDocUserSi { get; set; }
        public string InvDocUserTp { get; set; }
        public int? InvDocTypSi { get; set; }
    }
}
