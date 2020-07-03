using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvDocRqst
    {
        public int InvDocRqstSi { get; set; }
        public int? InvDocRqstSiParent { get; set; }
        public int? ProductionOrderPlanSheetMrpdetailId { get; set; }
        public string InvDocDExpNo { get; set; }
        public int? InvGdsSi { get; set; }
        public int? InvGdsAlternativeSi { get; set; }
        public double? InvDocRqstQty { get; set; }
        public double? InvDocRqstAlternativeQty { get; set; }
        public int? VoucherRow { get; set; }
        public string InvDocRqstType { get; set; }
        public string InvDocRqstDs { get; set; }
        public int? InvuntSi { get; set; }
    }
}
