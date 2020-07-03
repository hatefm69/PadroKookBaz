using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class Sysproperties
    {
        public int? Type { get; set; }
        public int Id { get; set; }
        public int MinorId { get; set; }
        public string Name { get; set; }
        public object Value { get; set; }
    }
}
