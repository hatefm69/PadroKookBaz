using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsGrpUserToUser
    {
        public int TrsGrpUserToUserSi { get; set; }
        public string UserRec { get; set; }
        public int? TrsGrpUserSi { get; set; }
    }
}
