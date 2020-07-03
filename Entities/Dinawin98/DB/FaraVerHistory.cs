using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class FaraVerHistory
    {
        public int FaraVerHistorySi { get; set; }
        public int? Row { get; set; }
        public int? SiSystem { get; set; }
        public string Description { get; set; }
        public string VersionNo { get; set; }
        public string DateDo { get; set; }

        public virtual FaraSystems SiSystemNavigation { get; set; }
    }
}
