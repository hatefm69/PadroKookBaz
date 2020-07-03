using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalOprUser
    {
        public int SalOprUserSi { get; set; }
        public string UserRec { get; set; }
        public int? SalOprSi { get; set; }

        public virtual SalOpr SalOprSiNavigation { get; set; }
    }
}
