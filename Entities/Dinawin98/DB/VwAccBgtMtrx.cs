using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwAccBgtMtrx
    {
        public string ماه { get; set; }
        public string عنوانماه { get; set; }
        public bool? فعال { get; set; }
        public string کدردیفبودجه { get; set; }
        public string عنوانردیفبودجه { get; set; }
        public double? مبلغدورهتقسیم { get; set; }
        public double? مبلغبودجه { get; set; }
    }
}
