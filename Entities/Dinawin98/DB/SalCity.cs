using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalCity
    {
        public int SalCitySi { get; set; }
        public int SalProvinceSi { get; set; }
        public double? SalCityCu { get; set; }
        public string SalCityTp { get; set; }
        public double? Cu2 { get; set; }

        public virtual SalProvince SalProvinceSiNavigation { get; set; }
    }
}
