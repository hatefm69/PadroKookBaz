using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PrdcTraceH
    {
        public PrdcTraceH()
        {
            PrdcTraceDinfo = new HashSet<PrdcTraceDinfo>();
        }

        public int PrdcTraceHSi { get; set; }
        public int? PrdcWorkOrderHSi { get; set; }
        public string PrdcTraceHDate { get; set; }
        public string PrdcTraceHCu { get; set; }
        public int? InvInvtSi { get; set; }
        public string PrdcTraceHDescription { get; set; }
        public bool? PrdcTraceHLock { get; set; }
        public bool? PrdcTraceHSendDoc { get; set; }
        public string PrdcTraceHCreatorUser { get; set; }
        public string PrdcTraceHConfirmationUser { get; set; }

        public virtual InvInvt InvInvtSiNavigation { get; set; }
        public virtual ICollection<PrdcTraceDinfo> PrdcTraceDinfo { get; set; }
    }
}
