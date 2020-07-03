using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class Pmplaning
    {
        public int PmPlanId { get; set; }
        public int? PmPlanCode { get; set; }
        public int? PmPlanUnit1 { get; set; }
        public double? PmPlanValue1 { get; set; }
        public int? PmPlanUnit2 { get; set; }
        public double? PmPlanValue2 { get; set; }
        public int? PmPlanMabna { get; set; }
        public int? PmServiceRefId { get; set; }
    }
}
