using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PmSysTem
    {
        public int PmSysTemId { get; set; }
        public int? PmSysTemCode { get; set; }
        public string PmSysTemDesc { get; set; }
        public int? PmCarCategoryRefId { get; set; }
    }
}
