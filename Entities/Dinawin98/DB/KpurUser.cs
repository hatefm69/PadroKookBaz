using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class KpurUser
    {
        public int PurUserSi { get; set; }
        public string PurUserCu { get; set; }
        public int? PurLvlDSi { get; set; }
        public int? CtbOrgDepSi { get; set; }
    }
}
