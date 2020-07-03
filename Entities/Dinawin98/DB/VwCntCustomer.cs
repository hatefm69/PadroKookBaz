using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwCntCustomer
    {
        public int CntCustomerSi { get; set; }
        public int? SalCustSi { get; set; }
        public string SalCustCu { get; set; }
        public string SalCustTp { get; set; }
        public int? CtbCustVndrTypSi { get; set; }
        public string CtbCustVndrTypTp { get; set; }
        public short? SalCustCorporateTyp { get; set; }
    }
}
