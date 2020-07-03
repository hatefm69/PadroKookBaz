using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwPrdcWorkOrderDinfoMaterial
    {
        public double? PrdcWorkOrderDinfoQuantity { get; set; }
        public int? PrdcLineTitleSi { get; set; }
        public int? PrdcBomSi { get; set; }
        public int? PrdcWorkOrderHSi { get; set; }
        public int PrdcWorkOrderDinfoSi { get; set; }
        public int? PrdcWorkOrderDmaterialSi { get; set; }
        public double? PrdcWorkOrderDmaterialValue { get; set; }
        public int? InvGdsSi { get; set; }
    }
}
