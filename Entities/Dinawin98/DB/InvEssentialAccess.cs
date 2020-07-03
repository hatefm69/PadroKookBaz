using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvEssentialAccess
    {
        public int InvEssentialAccessSi { get; set; }
        public string UsesRec { get; set; }
        public bool? InvEssentialAccessAct1 { get; set; }
        public bool? InvEssentialAccessAct2 { get; set; }
    }
}
