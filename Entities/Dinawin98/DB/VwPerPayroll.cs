﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwPerPayroll
    {
        public string PerPyrlPeriodTp { get; set; }
        public string PerPyrlPeriodDsStart { get; set; }
        public string PerPyrlPeriodDsEnd { get; set; }
        public int? PerPyrlPeriodWrkDays { get; set; }
        public string PerPayrollCu { get; set; }
        public string PerPayrollTp { get; set; }
        public string PerPayrollIf { get; set; }
        public string PerPayrollCalc { get; set; }
        public decimal PerPayrollValue { get; set; }
        public int PerPayrollSeq { get; set; }
        public int PerPyrlPeriodSi { get; set; }
        public int? PerPrsnlSi { get; set; }
        public string PerCmdCu { get; set; }
        public string PerCmdBgnDs { get; set; }
        public string PerCmdEndDs { get; set; }
        public string PerCmdCntrctNo { get; set; }
        public string PerPrsnlCu { get; set; }
        public string PerPrsnlTp { get; set; }
        public string PerPrsnlFname { get; set; }
        public string PerPrsnlLname { get; set; }
        public bool? PerPrsnlAct { get; set; }
        public string PerPrsnlDPname { get; set; }
        public string PerPrsnlDIdno { get; set; }
        public string PerPrsnlDIdloc { get; set; }
        public string PerPrsnlDBrtDte { get; set; }
        public bool? PerPrsnlDMarid { get; set; }
        public byte? PerPrsnlDChld { get; set; }
        public string PerPrsnlDSldr { get; set; }
        public string PerPrsnlDEdu { get; set; }
        public string PerPrsnlDEmpDte { get; set; }
        public string PerPrsnlDWrkBgnDte { get; set; }
        public string PerPrsnlDWrkEndDte { get; set; }
        public byte? PerPrsnlDSex { get; set; }
        public bool? PerPrsnlDFrgn { get; set; }
        public string PerPrsnlDEmail { get; set; }
        public string PerPrsnlDUrl { get; set; }
        public string PerPrsnlDTel1 { get; set; }
        public string PerPrsnlDTel2 { get; set; }
        public string PerPrsnlDFax { get; set; }
        public string PerPrsnlDAdrs { get; set; }
        public string PerPrsnlDBnkName { get; set; }
        public string PerPrsnlDBnkBrnch { get; set; }
        public string PerPrsnlDBnkAccNo { get; set; }
        public string PerPrsnlDBnkAccTyp { get; set; }
        public string InsrncFname { get; set; }
        public string InsrncLname { get; set; }
        public string InsrncDname { get; set; }
        public string InsrncIdno { get; set; }
        public string InsrncIdplc { get; set; }
        public string InsrncNat { get; set; }
        public string InsrncOcp { get; set; }
        public string CtbOrgPstTp { get; set; }
        public string CtbOrgPstCu { get; set; }
        public string CtbOrgDepTp { get; set; }
        public string CtbOrgDepCu { get; set; }
        public string CtbOrgJobCu { get; set; }
        public string CtbOrgJobTp { get; set; }
        public string InsrncNo { get; set; }
        public string PerPrsnlDIddte { get; set; }
        public int? CtbCostSi { get; set; }
        public int? CtbOrgDepSi { get; set; }
        public int? PerEmpTypSi { get; set; }
        public string CtbCostCu { get; set; }
        public string CtbCostTp { get; set; }
        public int PerOprGrpSi { get; set; }
        public byte? PerInsrncGrpSi { get; set; }
        public bool? PerPayrollDelayed { get; set; }
        public int? PerCmdSi { get; set; }
        public string PerPrsnlIdNatCode { get; set; }
        public int? CtbProjectSi { get; set; }
        public int? PerPrsnlDlocSi { get; set; }
        public int? PerPrsnlDPhoto { get; set; }
        public string PerPrsnlDMajor { get; set; }
        public string PerPrsnlDUniverCity { get; set; }
        public string PerPrsnlDmarid1 { get; set; }
        public DateTime? PerPrsnlDBuyBak { get; set; }
        public bool? PerCmdAct { get; set; }
        public string PerCmdTypCu { get; set; }
        public string PerCmdTypTp { get; set; }
        public string PerEmpTypCu { get; set; }
        public string PerEmpTypTp { get; set; }
        public string InsrncOcpcode { get; set; }
        public string PerInsrncGrpTp { get; set; }
        public int? BankAccountNo { get; set; }
        public string PerPrsnlDPostCode { get; set; }
        public int? PerPrsnlDHistoryJob { get; set; }
        public string InsrncOcptp { get; set; }
        public string PerPrsnlDCountry { get; set; }
        public int? PerPrsnlDInsureType { get; set; }
        public int? PerInterNationalSi { get; set; }
        public int? PerExemptSi { get; set; }
        public int? PerMajorSi { get; set; }
        public int? PereEducateSi { get; set; }
        public int? PerTaxGrpSi { get; set; }
        public int? PerLocSi { get; set; }
        public int? PerInsrnPromiseSi { get; set; }
        public string PerTaxGrpTp { get; set; }
        public bool? PerPayrollIsmovagh { get; set; }
        public string PereEducateCu { get; set; }
        public string PereEducateTp { get; set; }
        public string PerPrsnlDPost { get; set; }
        public string PerInsurTypeCu { get; set; }
        public string PerInsurTypeTp { get; set; }
        public string PerPrsnlDPostName { get; set; }
        public string PeremployeeStatusTp { get; set; }
        public string PeremployeeStatusCu { get; set; }
        public string PerPlaceOfficeStatusCu { get; set; }
        public string PerPlaceOfficeStatusTp { get; set; }
        public string PerPrsnlDPlaceOffice { get; set; }
        public int? PerPlaceOfficeStatusSi { get; set; }
        public int? PerPaidTypeSi { get; set; }
        public int? CtbCurncySi { get; set; }
        public double? ExchangeRate { get; set; }
        public int? PeremployeeStatusSi { get; set; }
        public int? PerVehicleFlagSi { get; set; }
        public int? PerFurnitureFlagSi { get; set; }
        public int? PerCurencySi { get; set; }
        public int? PerContractTypSi { get; set; }
        public string PerInsurnceName { get; set; }
        public string PerContractTypCu { get; set; }
        public string PerContractTypTp { get; set; }
    }
}
