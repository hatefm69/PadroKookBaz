using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class Pmworkmessure
    {
        public int WorkDurMessureId { get; set; }
        public int? WorkDurMessureCode { get; set; }
        public string WorkDurMessureTitle { get; set; }
        public string WorkDurMessureTitleLatin { get; set; }
    }
}
