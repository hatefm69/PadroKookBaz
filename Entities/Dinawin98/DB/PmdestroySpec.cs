using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PmdestroySpec
    {
        public int PmDestroySpecId { get; set; }
        public int? PmDestroySpecCode { get; set; }
        public string PmDestroySpecDesc { get; set; }
    }
}
