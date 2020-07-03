using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PerSponserShipD
    {
        public int PerSponserShipDSi { get; set; }
        public string PerSponserShipDCu { get; set; }
        public string PerSponserShipDFname { get; set; }
        public string PerSponserShipDLname { get; set; }
        public string PerSponserShipDIdno { get; set; }
        public int? PerSponserShipRelatedSi { get; set; }
        public string PerSponserShipBrtDte { get; set; }
        public string PerSponserShipDInsrncIdno { get; set; }
        public bool? PerSponserShipDRelatedCode { get; set; }
        public int? PerPrsnlSi { get; set; }
        public bool? PerSponserShipDOk { get; set; }
        public int? PerSponserShipDNatCode { get; set; }
        public int? PerSponserShipKasrBimeSi { get; set; }
    }
}
