using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class Pmplan
    {
        public int? PmPlanId { get; set; }
        public int? PmOperationDesRefId { get; set; }
        public int? PmPlanTime { get; set; }
        public int? PmPlanWork { get; set; }
    }
}
