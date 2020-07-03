using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvDocDefinit
    {
        public int InvDocDefinitSi { get; set; }
        public string LoginName { get; set; }
        public string InvDocDefinitTp { get; set; }
        public bool? EndLevel { get; set; }
        public int? LevelNo { get; set; }
        public bool? Inv { get; set; }
        public bool? Sc { get; set; }
        public bool? Pm { get; set; }
        public bool? Qc { get; set; }
        public bool? Mi { get; set; }
    }
}
