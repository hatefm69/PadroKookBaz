using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsGrpUser
    {
        public int TrsGrpUserSi { get; set; }
        public string TrsGrpUserCu { get; set; }
        public string TrsGrpUserTp { get; set; }
        public bool? TrsGrpUserManger { get; set; }
    }
}
