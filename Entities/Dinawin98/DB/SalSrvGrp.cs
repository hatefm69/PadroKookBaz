using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalSrvGrp
    {
        public int SalSrvGrpSi { get; set; }
        public string SalSrvGrpCu { get; set; }
        public string SalSrvGrpTp { get; set; }
        public int? SalSrvGrpSiParent { get; set; }
    }
}
