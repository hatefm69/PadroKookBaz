﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsCtyp
    {
        public TrsCtyp()
        {
            TrsDcC = new HashSet<TrsDcC>();
            TrsSts = new HashSet<TrsSts>();
        }

        public short TrsCtypSi { get; set; }
        public string TrsCtypTp { get; set; }
        public string TrsCtypTp2 { get; set; }

        public virtual ICollection<TrsDcC> TrsDcC { get; set; }
        public virtual ICollection<TrsSts> TrsSts { get; set; }
    }
}
