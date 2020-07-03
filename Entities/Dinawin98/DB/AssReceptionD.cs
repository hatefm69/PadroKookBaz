using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AssReceptionD
    {
        public int AssReceptionDSi { get; set; }
        public int AssReceptionSi { get; set; }
        public string AssMachineSerial { get; set; }

        public virtual AssReception AssReceptionSiNavigation { get; set; }
    }
}
