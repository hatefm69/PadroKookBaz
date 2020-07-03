using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class BgtAssignToPrj
    {
        public BgtAssignToPrj()
        {
            BgtAssignToPrjDetail = new HashSet<BgtAssignToPrjDetail>();
        }

        public int BgtAssignToPrjSi { get; set; }
        public int? BgtAssignAccMSi { get; set; }
        public decimal? BgtAssignToPrjAmnt { get; set; }
        public int? SiProject { get; set; }
        public DateTime? BgtAssignToPrjDate { get; set; }

        public virtual BgtAssignAccM BgtAssignAccMSiNavigation { get; set; }
        public virtual CtbProject SiProjectNavigation { get; set; }
        public virtual ICollection<BgtAssignToPrjDetail> BgtAssignToPrjDetail { get; set; }
    }
}
