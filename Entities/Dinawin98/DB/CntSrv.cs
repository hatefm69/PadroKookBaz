using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CntSrv
    {
        public int CntSrvSi { get; set; }
        public int CntContractSi { get; set; }
        public string CntSrvTx { get; set; }
        public double? CntSrvQuantity { get; set; }
        public string CntSrvMeasureUnit { get; set; }
        public decimal? CntSrvUnitPrice { get; set; }
        public string CntSrvComment { get; set; }

        public virtual CntContract CntContractSiNavigation { get; set; }
    }
}
