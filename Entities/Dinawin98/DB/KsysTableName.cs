using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class KsysTableName
    {
        public int TabId { get; set; }
        public string Tabname { get; set; }
        public bool? TabSys { get; set; }
        public int? TabOrder { get; set; }
    }
}
