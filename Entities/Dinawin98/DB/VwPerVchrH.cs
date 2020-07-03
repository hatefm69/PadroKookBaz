﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwPerVchrH
    {
        public int PerVchrHId { get; set; }
        public DateTime? PerVchrHDate { get; set; }
        public DateTime? PerVchrHDateFrom { get; set; }
        public DateTime? PerVchrHDateUntil { get; set; }
        public string PerVchrHTx { get; set; }
        public bool? PerVchrHSent { get; set; }
        public int? AccDocHSi { get; set; }
        public int? CuDoc { get; set; }
        public DateTime? DsDoc { get; set; }
        public int? SecCuDoc { get; set; }
    }
}
