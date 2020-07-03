using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CntTrack
    {
        public int CntTrackSi { get; set; }
        public int CntContractSi { get; set; }
        public string CntTrackDate { get; set; }
        public string CntTrackTx { get; set; }
        public string CntTrackComment { get; set; }

        public virtual CntContract CntContractSiNavigation { get; set; }
    }
}
