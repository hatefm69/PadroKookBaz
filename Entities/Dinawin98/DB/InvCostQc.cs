using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvCostQc
    {
        public InvCostQc()
        {
            InvCostQcUser = new HashSet<InvCostQcUser>();
        }

        public int InvCostQcSi { get; set; }
        public string InvCostQcCu { get; set; }
        public string InvCostQcTp { get; set; }

        public virtual ICollection<InvCostQcUser> InvCostQcUser { get; set; }
    }
}
