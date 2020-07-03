using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwPrdcWorkOrderDinfo
    {
        public int PrdcWorkOrderDinfoSi { get; set; }
        public double? PrdcWorkOrderDinfoQuantity { get; set; }
        public int? PrdcWorkOrderHSi { get; set; }
        public string PrdcBomFormula { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string PrdcLineTitleTp { get; set; }
    }
}
