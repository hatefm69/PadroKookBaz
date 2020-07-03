using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PmcarCategory
    {
        public int PmCarCategoryId { get; set; }
        public string PmCarCategoryCode { get; set; }
        public string PmCarCategoryDesc { get; set; }
        public int? PmCarCategoryUnitRefId { get; set; }
        public int? PmCarCategoryDayWork { get; set; }
        public double? PmCarCategoryCostStop { get; set; }
    }
}
