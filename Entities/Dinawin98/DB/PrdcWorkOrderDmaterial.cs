using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PrdcWorkOrderDmaterial
    {
        public int PrdcWorkOrderDmaterialSi { get; set; }
        public int? PrdcWorkOrderDinfoSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double? PrdcWorkOrderDmaterialValue { get; set; }
        public int? PrdcBomdSi { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual PrdcWorkOrderDinfo PrdcWorkOrderDinfoSiNavigation { get; set; }
    }
}
