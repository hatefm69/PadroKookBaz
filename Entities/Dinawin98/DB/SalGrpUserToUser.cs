using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalGrpUserToUser
    {
        public int SalGrpUserToUserSi { get; set; }
        public string UserRec { get; set; }
        public int? SalGrpUserSi { get; set; }
        public bool? SalGrpUserToUserIsManager { get; set; }

        public virtual SalGrpUser SalGrpUserSiNavigation { get; set; }
    }
}
