using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class BgtAssignToCcostDetail
    {
        public int BgtAssignToCcostDetailSi { get; set; }
        public int? BgtAssignToCcostSi { get; set; }
        public decimal? BgtAssignToCcostDetailAmnt { get; set; }
        public DateTime? BgtAssignToCcostDetailDate { get; set; }
        public string BgtAssignToCcostDetailDesc { get; set; }
        public string BgtAssignToCcostDetailCu { get; set; }
        public int? SiAccM { get; set; }

        public virtual BgtAssignToCcost BgtAssignToCcostSiNavigation { get; set; }
    }
}
