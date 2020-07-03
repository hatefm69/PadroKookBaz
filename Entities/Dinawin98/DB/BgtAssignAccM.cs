using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class BgtAssignAccM
    {
        public BgtAssignAccM()
        {
            BgtAssignToCcost = new HashSet<BgtAssignToCcost>();
            BgtAssignToPrj = new HashSet<BgtAssignToPrj>();
        }

        public int BgtAssignAccMSi { get; set; }
        public int SiAccM { get; set; }
        public DateTime? BgtAssignAccMDate { get; set; }
        public decimal? BgtAssignAccMAmnt { get; set; }

        public virtual CtbAccM SiAccMNavigation { get; set; }
        public virtual ICollection<BgtAssignToCcost> BgtAssignToCcost { get; set; }
        public virtual ICollection<BgtAssignToPrj> BgtAssignToPrj { get; set; }
    }
}
