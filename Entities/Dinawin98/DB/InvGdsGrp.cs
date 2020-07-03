using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvGdsGrp
    {
        public int InvGdsGrpSi { get; set; }
        public string InvGdsGrpCu { get; set; }
        public string InvGdsGrpTp { get; set; }
        public int? InvGdsGrpSiParent { get; set; }
        public bool? IsServiced { get; set; }
    }
}
