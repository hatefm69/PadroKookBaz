using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwSalPurso
    {
        public string SalCustCu { get; set; }
        public string SalCustTp { get; set; }
        public string SalPursueDateEnter { get; set; }
        public string SalPursueDateEdit { get; set; }
        public string SalPursueDatePursue { get; set; }
        public string SalPursueDesc { get; set; }
        public string SalPursueUserSave { get; set; }
        public string SalPursueUserEdit { get; set; }
        public int? SalCustSi { get; set; }
        public int SalPursueSi { get; set; }
        public bool SalPursueHaveFile { get; set; }
        public string SalPursueTp { get; set; }
        public bool? SalPursueIsFinall { get; set; }
    }
}
