using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PurGdsToVndr
    {
        public int PurGdsToVndrSi { get; set; }
        public int? InvGdsSi { get; set; }
        public int? PurVndrSi { get; set; }
    }
}
