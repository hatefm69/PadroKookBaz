using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwSalSrv
    {
        public int SalSrvSi { get; set; }
        public string SalSrvCu { get; set; }
        public string SalSrvTp { get; set; }
        public int? SalSrvSiParent { get; set; }
        public string SalSrvUnt { get; set; }
    }
}
