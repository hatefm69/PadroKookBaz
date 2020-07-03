using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalRegion
    {
        public int SalRegionSi { get; set; }
        public string SalRegionCu { get; set; }
        public int? SalCitySi { get; set; }
        public string SalRegionTp { get; set; }
    }
}
