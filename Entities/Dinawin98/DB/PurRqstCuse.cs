using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PurRqstCuse
    {
        public PurRqstCuse()
        {
            PurRqstH = new HashSet<PurRqstH>();
        }

        public int PurRqstCuseSi { get; set; }
        public string PurRqstCuseTp { get; set; }

        public virtual ICollection<PurRqstH> PurRqstH { get; set; }
    }
}
