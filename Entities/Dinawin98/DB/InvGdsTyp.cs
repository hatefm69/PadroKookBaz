﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvGdsTyp
    {
        public InvGdsTyp()
        {
            InvDocDsrl = new HashSet<InvDocDsrl>();
            SalDclrPrcD = new HashSet<SalDclrPrcD>();
        }

        public int InvGdsSi { get; set; }
        public int InvGdsTypSi { get; set; }
        public string InvGdsTypTp { get; set; }
        public int InvUntSi { get; set; }

        public virtual InvUnt InvUntSiNavigation { get; set; }
        public virtual ICollection<InvDocDsrl> InvDocDsrl { get; set; }
        public virtual ICollection<SalDclrPrcD> SalDclrPrcD { get; set; }
    }
}
