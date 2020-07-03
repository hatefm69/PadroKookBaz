using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class BgtAssignToPrjSubDetail
    {
        public int BgtAssignToPrjSubDetailSi { get; set; }
        public int? BgtAssignToPrjDetailSi { get; set; }
        public decimal? BgtAssignToPrjSubDetailAmnt { get; set; }
        public DateTime? BgtAssignToPrjSubDetailDate { get; set; }
        public string BgtAssignToPrjSubDetailDesc { get; set; }
        public int? RequestId { get; set; }

        public virtual BgtAssignToPrjDetail BgtAssignToPrjDetailSiNavigation { get; set; }
    }
}
