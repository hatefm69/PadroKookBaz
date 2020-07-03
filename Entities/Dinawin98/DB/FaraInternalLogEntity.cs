using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class FaraInternalLogEntity
    {
        public string TableName { get; set; }
        public string KeyColumn { get; set; }
        public string DescriptionColumn { get; set; }
        public string NumberColumn { get; set; }
        public bool Active { get; set; }
        public bool LogInsert { get; set; }
        public bool LogUpdate { get; set; }
        public bool? LogDelete { get; set; }
    }
}
