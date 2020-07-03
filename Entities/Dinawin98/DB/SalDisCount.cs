using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalDisCount
    {
        public SalDisCount()
        {
            SalInvcD = new HashSet<SalInvcD>();
        }

        public int SalDisCountId { get; set; }
        public string SalDisCountTx { get; set; }

        public virtual ICollection<SalInvcD> SalInvcD { get; set; }
    }
}
