using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class MonitorRule
    {
        public int Code { get; set; }
        public string RuleExpr { get; set; }
    }
}
