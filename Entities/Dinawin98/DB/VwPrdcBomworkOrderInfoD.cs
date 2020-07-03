using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwPrdcBomworkOrderInfoD
    {
        public int PrdcWorkOrderDinfoSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string PrdcBomFormula { get; set; }
        public double? PrdcBomQuantity { get; set; }
        public int? PrdcLineTitleCu { get; set; }
        public string PrdcLineTitleTp { get; set; }
        public bool? PrdcBomChangeInWorkOrder { get; set; }
        public bool? PrdcLineChangeInWorkOrder { get; set; }
        public double? PrdcWorkOrderDinfoQuantity { get; set; }
        public int? PrdcWorkOrderHSi { get; set; }
    }
}
