using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccGrpUserToUser
    {
        public int AccGrpUserToUserSi { get; set; }
        public string UserRec { get; set; }
        public int? AccGrpUserSi { get; set; }
    }
}
