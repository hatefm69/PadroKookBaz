using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class BgtAssignToCcostSubDetail
    {
        public int BgtAssignToCcostSubDetailSi { get; set; }
        public int? BgtAssignToCcostDetailSi { get; set; }
        public decimal? BgtAssignToCcostSubDetailAmnt { get; set; }
        public DateTime? BgtAssignToCcostSubDetailDate { get; set; }
        public string BgtAssignToCcostSubDetailDesc { get; set; }
        public int? RequestId { get; set; }
    }
}
