using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class DimDate
    {
        public int DateId { get; set; }
        public DateTime Gdate { get; set; }
        public string Pdate { get; set; }
        public int Pyear { get; set; }
        public int Pmonth { get; set; }
        public int Pday { get; set; }
        public string PmonthName { get; set; }
        public int PweekOfYear { get; set; }
        public string PdayName { get; set; }
        public string Pseason { get; set; }
    }
}
