using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class Invgds2
    {
        public int InvGdsSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvGdsCm { get; set; }
        public int InvUntSi { get; set; }
        public int InvGdsGrpSi { get; set; }
        public string InvGdsTechNo { get; set; }
        public double InvGdsQtyReal { get; set; }
        public double InvGdsQtyVirtual { get; set; }
        public double InvGdsQtyMin { get; set; }
        public double InvGdsQtyMax { get; set; }
        public double InvGdsQtySafe { get; set; }
        public bool InvGdsPrdGds { get; set; }
        public string InvGdsLname { get; set; }
        public int? InvGdsIcntrySi { get; set; }
        public int? InvGdsIcratrSi { get; set; }
        public decimal? InvGdsStdPrc { get; set; }
        public decimal? InvGdsPurchasePrc { get; set; }
        public int? InvUntSiSale { get; set; }
        public decimal? InvGdsSalePrc { get; set; }
        public int? InvUntCount { get; set; }
        public int? InvGdsStatusSi { get; set; }
        public int? Siaccm { get; set; }
        public string InvGdsGrpSiParent { get; set; }
        public int? PurGdsGrpSi { get; set; }
        public decimal? InvGdsPurchasePrcC { get; set; }
        public DateTime? InvGdsDateBirth { get; set; }
        public bool? InvGdsActive { get; set; }
        public double? InvGdsQtySale { get; set; }
        public bool? InvGdsActiveSale { get; set; }
        public bool? InvGdsActiveSerial { get; set; }
        public double? InvGdsQtyMinOrd { get; set; }
        public double? InvGdsQtyBestInWay { get; set; }
        public int? InvGdsCountdayInWay { get; set; }
        public int? SiAccT { get; set; }
        public bool? ShowInWeb { get; set; }
        public int? InvbasketGdsSi { get; set; }
        public int? InvGdsGrpSi2 { get; set; }
        public int? CtbCurncySi { get; set; }
        public int? PlaneNo { get; set; }
        public int? EmployerNo { get; set; }
        public double? InvGdsBurden { get; set; }
        public int? InvGdsHeight { get; set; }
        public int? InvGdsWidth { get; set; }
        public int? InvGdsLength { get; set; }
    }
}
