using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwInvRemainQtyBorrow
    {
        public double? RemainQty { get; set; }
        public decimal? InvDocDPrice { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public double? SumInvQty { get; set; }
        public double? SumInvQty1 { get; set; }
        public int InvGdsSi { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public int? PurVndrSi { get; set; }
        public string InvDocHDs { get; set; }
        public int? InvDocHCu { get; set; }
        public int? SalCustSi { get; set; }
        public string SalCustCu { get; set; }
        public string SalCustTp { get; set; }
    }
}
