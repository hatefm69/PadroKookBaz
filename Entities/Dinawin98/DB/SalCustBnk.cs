using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalCustBnk
    {
        public int SalCustBnkSi { get; set; }
        public string SalCustBnkAccountNo { get; set; }
        public string SalCustBnkBranch { get; set; }
        public string SalCustBnkBankName { get; set; }
        public int? SalCustSi { get; set; }
    }
}
