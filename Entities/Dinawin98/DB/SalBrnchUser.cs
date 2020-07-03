using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalBrnchUser
    {
        public int SalBrnchUserSi { get; set; }
        public string UserRec { get; set; }
        public int? SalBrnchSi { get; set; }

        public virtual SalBrnch SalBrnchSiNavigation { get; set; }
    }
}
