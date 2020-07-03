using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PmDserVice
    {
        public int PmDserviceId { get; set; }
        public int? PmDserviceCode { get; set; }
        public string PmDserviceDesc { get; set; }
        public int? PmDpriorityRefId { get; set; }
        public int? PmDaccessRefId { get; set; }
        public int? PmDserviceType { get; set; }
        public int? PmDcarCategoryRefId { get; set; }
        public int? PmDserviceTime { get; set; }
    }
}
