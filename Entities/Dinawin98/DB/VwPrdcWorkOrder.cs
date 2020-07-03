using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwPrdcWorkOrder
    {
        public string PrdcWorkOrderHToDate { get; set; }
        public string PrdcWorkOrderHFromDate { get; set; }
        public bool? PrdcWorkOrderHStatus { get; set; }
        public short? PrdcWorkOrderHPriority { get; set; }
        public string PrdcWorkOrderHDate { get; set; }
        public string PrdcWorkOrderHCu { get; set; }
        public int PrdcWorkOrderHSi { get; set; }
        public int? InvGdsSi { get; set; }
        public string PrdcLineTitleTp { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string PrdcBomFormula { get; set; }
    }
}
