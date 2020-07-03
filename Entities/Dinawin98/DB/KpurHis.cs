using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class KpurHis
    {
        public int PurHisSi { get; set; }
        public string PurHisCu { get; set; }
        public DateTime? PurHisDt { get; set; }
        public string PurHisDs { get; set; }
        public string PurHisUser { get; set; }
        public int? PurLvlSi { get; set; }
        public int? PurRqstHSi { get; set; }
        public int? PurHisUserLvl { get; set; }
    }
}
