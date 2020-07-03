using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class FaraDbver
    {
        public byte? Major { get; set; }
        public byte? Minor { get; set; }
        public byte? Release { get; set; }
        public byte? Build { get; set; }
    }
}
