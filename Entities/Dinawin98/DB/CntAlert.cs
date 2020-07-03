using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CntAlert
    {
        public int CntAlertSi { get; set; }
        public int CntContractSi { get; set; }
        public string CntAlertDate { get; set; }
        public string CntAlertTx { get; set; }
        public bool? CntAlertDismiss { get; set; }
        public int? CntTaskSi { get; set; }
        public int? CntAlertDayBeforeAlert { get; set; }
        public int? CntAlertPrgssBeforeAlert { get; set; }
        public short? CntAlertTyp { get; set; }

        public virtual CntContract CntContractSiNavigation { get; set; }
    }
}
