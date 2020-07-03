using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalRespUser
    {
        public int SalRespUserSi { get; set; }
        public string UserRec { get; set; }
        public int? SalRespSi { get; set; }

        public virtual SalResp SalRespSiNavigation { get; set; }
    }
}
