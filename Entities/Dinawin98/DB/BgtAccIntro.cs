using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class BgtAccIntro
    {
        public int BgtAccIntroSi { get; set; }
        public int AccMSi { get; set; }
        public byte? BgtAccIntroNature { get; set; }
        public double? BgtAccIntroConst { get; set; }

        public virtual CtbAccM AccMSiNavigation { get; set; }
    }
}
