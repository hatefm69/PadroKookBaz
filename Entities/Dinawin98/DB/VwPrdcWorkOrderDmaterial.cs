using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwPrdcWorkOrderDmaterial
    {
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvUntTp { get; set; }
        public int PrdcWorkOrderDmaterialSi { get; set; }
        public int? PrdcWorkOrderDinfoSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double? PrdcWorkOrderDmaterialValue { get; set; }
        public int? PrdcBomdSi { get; set; }
    }
}
