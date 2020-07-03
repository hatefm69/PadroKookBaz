using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class HeaderRandomStorage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string StartDateDs { get; set; }
        public DateTime? StartDateDm { get; set; }
        public int? Duration { get; set; }
    }
}
