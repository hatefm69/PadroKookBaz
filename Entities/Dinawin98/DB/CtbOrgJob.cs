using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CtbOrgJob
    {
        public CtbOrgJob()
        {
            CtbOrgPst = new HashSet<CtbOrgPst>();
            PerCmd = new HashSet<PerCmd>();
        }

        public int CtbOrgJobSi { get; set; }
        public string CtbOrgJobCu { get; set; }
        public string CtbOrgJobTp { get; set; }
        public short? CtbOrgJobPrmt { get; set; }
        public short? CtbOrgJobAsgn { get; set; }

        public virtual ICollection<CtbOrgPst> CtbOrgPst { get; set; }
        public virtual ICollection<PerCmd> PerCmd { get; set; }
    }
}
