using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccDocLock
    {
        public int AccDocLockSi { get; set; }
        public DateTime AccDocLockFr { get; set; }
        public DateTime AccDocLockTo { get; set; }
        public string AccDocLockTx { get; set; }
        public bool? AccDocLockActive { get; set; }
    }
}
