using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalProvince
    {
        public SalProvince()
        {
            SalCity = new HashSet<SalCity>();
        }

        public int SalProvinceSi { get; set; }
        public string SalProvinceCu { get; set; }
        public string SalProvinceTp { get; set; }
        public int? SalCountrySi { get; set; }

        public virtual ICollection<SalCity> SalCity { get; set; }
    }
}
