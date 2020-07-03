using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwCntTrackAlerts
    {
        public string CntNo { get; set; }
        public string CntSubject { get; set; }
        public string AlertIndex { get; set; }
        public string AlertTx { get; set; }
        public int? CntContractSi { get; set; }
        public string CntContractDate { get; set; }
    }
}
