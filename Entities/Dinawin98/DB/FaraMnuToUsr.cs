using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class FaraMnuToUsr
    {
        public int FaraMnuToUsrSi { get; set; }
        public int? FaraMnuSi { get; set; }
        public string LoginName { get; set; }

        public virtual FaraMnu FaraMnuSiNavigation { get; set; }
    }
}
