using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class FaraMrtReport
    {
        public int FaraMrtReportId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int? FaraMrtReportTypeId { get; set; }

        public virtual FaraMrtReportType FaraMrtReportType { get; set; }
    }
}
