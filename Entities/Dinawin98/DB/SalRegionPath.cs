using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalRegionPath
    {
        public int SalRegionPathSi { get; set; }
        public int SalRegionSi { get; set; }
        public string SalRegionPathCu { get; set; }
        public string SalRegionPathTp { get; set; }
    }
}
