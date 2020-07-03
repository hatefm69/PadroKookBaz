using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccDocHattacH
    {
        public int AccDocHattachSi { get; set; }
        public string AccDocHattachDs { get; set; }
        public string AccDocHattachTp { get; set; }
        public string AccDocHattachFileName { get; set; }
        public byte[] AccDocHattachFile { get; set; }
        public int? SiHdoc { get; set; }
        public string AccDocHattachFileExtension { get; set; }

        public virtual AccHdoc SiHdocNavigation { get; set; }
    }
}
