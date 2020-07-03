using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class Zone
    {
        public double? ShahrCode { get; set; }
        public string Shahr { get; set; }
        public string Ostan { get; set; }
        public double? OstanCode { get; set; }
    }
}
