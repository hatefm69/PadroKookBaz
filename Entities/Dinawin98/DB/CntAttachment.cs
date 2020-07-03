﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CntAttachment
    {
        public int CntAttachmentSi { get; set; }
        public int CntContractSi { get; set; }
        public string CntAttachmentTx { get; set; }
        public byte[] CntAttachmentFile { get; set; }
        public string CntAttachmentFileName { get; set; }
        public int? CntAttachmentFileSize { get; set; }
        public string CntAttachmentFileType { get; set; }
        public int? CntAttachTypSi { get; set; }

        public virtual CntAttachTyp CntAttachTypSiNavigation { get; set; }
        public virtual CntContract CntContractSiNavigation { get; set; }
    }
}
