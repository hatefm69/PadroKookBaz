using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccRqstSts
    {
        public AccRqstSts()
        {
            AccArqst = new HashSet<AccArqst>();
        }

        public int AccRqstStsSi { get; set; }
        public string AccRqstStsTp { get; set; }

        public virtual ICollection<AccArqst> AccArqst { get; set; }
    }
}
