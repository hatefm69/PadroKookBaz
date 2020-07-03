using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PmCauseDestroy
    {
        public int PmCauseDestroyId { get; set; }
        public int? PmCauseDestroyCode { get; set; }
        public string PmCauseDestroyDesc { get; set; }
        public string PmCauseDestroySolution { get; set; }
        public int? PmDestroySpecRefId { get; set; }
    }
}
