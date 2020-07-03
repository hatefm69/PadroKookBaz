using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwCntLock
    {
        public string CntLockUserName { get; set; }
        public string CntLockDate { get; set; }
        public int? CntContractSi { get; set; }
        public string CntLockProcessLevelTx { get; set; }
        public int? CntLockProcessSi { get; set; }
        public int CntLockSi { get; set; }
        public bool? CntLockProcessEndLevel { get; set; }
        public string CntLockComment { get; set; }
    }
}
