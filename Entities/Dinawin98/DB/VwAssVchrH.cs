﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwAssVchrH
    {
        public int AssVchrHId { get; set; }
        public DateTime AssVchrHDate { get; set; }
        public DateTime AssVchrHDateFrom { get; set; }
        public DateTime AssVchrHDateUntil { get; set; }
        public string AssVchrHTx { get; set; }
        public bool? AssVchrHSent { get; set; }
        public int? AccDocHSi { get; set; }
        public int? CuDoc { get; set; }
        public DateTime? DsDoc { get; set; }
        public int? SecCuDoc { get; set; }
    }
}
