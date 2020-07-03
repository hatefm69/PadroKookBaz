using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalUserLevel
    {
        public int SalUserLevelSi { get; set; }
        public string SalUserLevelUserCode { get; set; }
        public string SalUserLevelUserName { get; set; }
        public int? SalUserLevelSiParent { get; set; }
        public short? LevelNo { get; set; }
    }
}
