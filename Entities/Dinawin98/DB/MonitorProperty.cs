using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class MonitorProperty
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Hotkey { get; set; }
    }
}
