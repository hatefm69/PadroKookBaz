using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwSalDepend
    {
        public string SalCustCu { get; set; }
        public string SalCustTp { get; set; }
        public string SalDependTp { get; set; }
        public string SalDependJob { get; set; }
        public string SalDependEmail { get; set; }
        public string SalDependMobile { get; set; }
        public string SalDependTel { get; set; }
        public bool? SalDependIsMain { get; set; }
        public string SalDependDesc { get; set; }
        public int? SalCustSi { get; set; }
    }
}
