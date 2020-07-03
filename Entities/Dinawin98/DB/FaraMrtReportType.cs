using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class FaraMrtReportType
    {
        public FaraMrtReportType()
        {
            FaraMrtReport = new HashSet<FaraMrtReport>();
        }

        public int FaraMrtReportTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FaraMrtReport> FaraMrtReport { get; set; }
    }
}
