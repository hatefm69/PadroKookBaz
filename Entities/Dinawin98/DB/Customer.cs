using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class Customer
    {
        public double? Si { get; set; }
        public double? CustCode { get; set; }
        public string CustTp { get; set; }
        public string Addres { get; set; }
        public string استانقدیم { get; set; }
        public string شهرستانقدیم { get; set; }
        public string شهرقدیم { get; set; }
        public string CountryCu { get; set; }
        public string Ostancu { get; set; }
        public string CityCu { get; set; }
        public string RegionCu { get; set; }
        public string MasirCu { get; set; }
        public string گروهاصلیمشتری { get; set; }
        public string گروهفرعیمشتری { get; set; }
        public string کدجدیدمشتری { get; set; }
    }
}
