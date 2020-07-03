using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PurGdsGrp
    {
        public int PurGdsGrpSi { get; set; }
        public string PurGdsGrpCu { get; set; }
        public string PurGdsGrpTp { get; set; }
        public int? PurGdsGrpSiParent { get; set; }
    }
}
