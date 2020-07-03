using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccountRelation
    {
        public string GeneralCode { get; set; }
        public string SubsidiaryCode { get; set; }
        public string DetailCode { get; set; }
        public string CostCenterCode { get; set; }
        public string ProjectCode { get; set; }
        public int? Nature { get; set; }
    }
}
