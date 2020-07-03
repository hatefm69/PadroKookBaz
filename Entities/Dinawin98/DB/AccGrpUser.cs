using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccGrpUser
    {
        public int AccGrpUserSi { get; set; }
        public string AccGrpUserCu { get; set; }
        public string AccGrpUserTp { get; set; }
        public bool? AccGrpUserManger { get; set; }
    }
}
