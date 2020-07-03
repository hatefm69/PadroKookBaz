using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class MonitorAccess
    {
        public int Code { get; set; }
        public string DefaultBehavior { get; set; }
        public string ExceptUserNames { get; set; }
    }
}
