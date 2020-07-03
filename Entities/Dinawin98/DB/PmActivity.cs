using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PmActivity
    {
        public int PmActivityId { get; set; }
        public string PmActivityDesc { get; set; }
        public int PmServiceRefId { get; set; }
    }
}
