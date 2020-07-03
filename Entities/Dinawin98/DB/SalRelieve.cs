using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalRelieve
    {
        public int SalRelieveSi { get; set; }
        public int? SiAccM { get; set; }
        public int? SalRelieveCu { get; set; }
        public string SalRelieveTp { get; set; }
    }
}
