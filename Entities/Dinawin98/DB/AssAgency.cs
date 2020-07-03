using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AssAgency
    {
        public AssAgency()
        {
            AssReceiptH = new HashSet<AssReceiptH>();
        }

        public int AssAgencySi { get; set; }
        public int? AssAgencyCu { get; set; }
        public string AssAgencyTp { get; set; }
        public string AssAgencyMng { get; set; }

        public virtual ICollection<AssReceiptH> AssReceiptH { get; set; }
    }
}
