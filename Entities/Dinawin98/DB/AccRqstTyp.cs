using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccRqstTyp
    {
        public AccRqstTyp()
        {
            AccArqst = new HashSet<AccArqst>();
        }

        public int AccRqstTypSi { get; set; }
        public string AccRqstTypTp { get; set; }

        public virtual ICollection<AccArqst> AccArqst { get; set; }
    }
}
