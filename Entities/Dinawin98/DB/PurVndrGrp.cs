using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PurVndrGrp
    {
        public PurVndrGrp()
        {
            PurVndr = new HashSet<PurVndr>();
        }

        public int PurVndrGrpSi { get; set; }
        public string PurVndrGrpCu { get; set; }
        public string PurVndrGrpTp { get; set; }
        public int? PurVndrGrpSiParent { get; set; }

        public virtual ICollection<PurVndr> PurVndr { get; set; }
    }
}
