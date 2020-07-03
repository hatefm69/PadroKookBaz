using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalGuranty
    {
        public int SalGurantySi { get; set; }
        public string SalGurantyHtyp { get; set; }
        public string SalGurantyHcu { get; set; }
        public string SalGurantyPcu { get; set; }
        public string SalGurantySerial { get; set; }
        public DateTime? SalGurantyBdate { get; set; }
        public DateTime? SalGurantyEdate { get; set; }
        public int? SalInvcHSi { get; set; }
        public int? SalCustSi { get; set; }
    }
}
