using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvExportPrmD
    {
        public int InvExportPrmDSi { get; set; }
        public int? InvExportPrmHSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double? InvExportPrmDQty { get; set; }
        public int? InvUntSi { get; set; }
        public string InvExportPrmDTp { get; set; }
        public int? InvGdsTypSi { get; set; }
        public int? PurchaseSendDetailId { get; set; }

        public virtual InvExportPrmH InvExportPrmHSiNavigation { get; set; }
    }
}
