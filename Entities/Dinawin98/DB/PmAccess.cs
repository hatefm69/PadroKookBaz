using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PmAccess
    {
        public int PmAccessId { get; set; }
        public int? PmAcessCode { get; set; }
        public string PmAccessDesc { get; set; }
    }
}
