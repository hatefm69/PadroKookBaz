using Entities;
using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccAdvR
    {
        public int AccAdvRSi { get; set; }
        public DateTime? AccAdvRDs { get; set; }
        public int SiDdoc { get; set; }
        public string AccAdvRTp { get; set; }
        public int SiAccT { get; set; }
        public bool AccAdvRCancle { get; set; }
        public int? SiHdoc { get; set; }
    }
}
