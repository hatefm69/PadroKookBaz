using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class FaraLog
    {
        public Guid LogSi { get; set; }
        public DateTime LogDt { get; set; }
        public string LogCtgry { get; set; }
        public string LogAction { get; set; }
        public string LogUser { get; set; }
        public string LogDesc { get; set; }
        public int? SiSystem { get; set; }
    }
}
