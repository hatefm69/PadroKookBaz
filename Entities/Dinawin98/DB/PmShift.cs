using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PmShift
    {
        public int? PmShiftId { get; set; }
        public int? PmShiftCode { get; set; }
        public string PmShiftDesc { get; set; }
        public double? PmShiftStartTime { get; set; }
        public double? PmShiftEndTime { get; set; }
        public int? PmShiftStatus { get; set; }
    }
}
