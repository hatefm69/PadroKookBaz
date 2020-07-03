using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsDocLock
    {
        public int TrsDocLockSi { get; set; }
        public DateTime TrsDocLockFr { get; set; }
        public DateTime TrsDocLockTo { get; set; }
        public string TrsDocLockTx { get; set; }
        public bool TrsDocLockActive { get; set; }
    }
}
